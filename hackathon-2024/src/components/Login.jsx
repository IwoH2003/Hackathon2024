import React, { useContext, useEffect } from "react";
import { useNavigate } from "react-router-dom"; // Import useNavigate instead of useHistory
import { useFormik } from "formik";
import { AppContext } from "../App";
import axios from "axios";
import motherAndChild from "../video/motherAndChild.mp4";
import "../styles/LoginPage.css";

export function Login() {
  const navigate = useNavigate(); // Use useNavigate here
  const { setLogged, logged, setUserId } = useContext(AppContext);
  useEffect(() => {
    if (logged) {
      navigate("/landingPage");
    }
  });
  const formik = useFormik({
    initialValues: {
      email: "",
      password: "",
    },
    onSubmit: (values) => {
      axios
        .post("https://hackaton2024api.azurewebsites.net/api/account/login", {
          email: values.email,
          password: values.password,
        })
        .then((response) => {
          sessionStorage.setItem("accessKey", response.data.jwt);
          sessionStorage.setItem("id", response.data.id);
          setLogged(true);
          setUserId(response.data.id);
          navigate("/landingPage");
        })
        .catch((error) => {
          console.error("Login failed:", error);
          alert("Login failed. Please check your credentials.");
        });
    },
  });

  return (
    <>
      <div className="login-container">
        {/* Background Video */}
        <video autoPlay loop muted playsInline className="background-video">
          <source src={motherAndChild} type="video/mp4" />
          Your browser does not support the video tag.
        </video>

        {/* Overlay for dimming */}
        <div className="overlay"></div>

        {/* Login Form */}
        <form className="login-form" onSubmit={formik.handleSubmit}>
          <label htmlFor="email">Email Address</label>
          <input
            id="email"
            name="email"
            type="email"
            onChange={formik.handleChange}
            value={formik.values.email}
          />
          <label htmlFor="password">Password</label>
          <input
            id="password"
            name="password"
            type="password"
            onChange={formik.handleChange}
            value={formik.values.password}
          />

          <button type="submit">Submit</button>
        </form>
        <div className="content-container">
          <p>If you don't have an account, go to register</p>
          <button onClick={() => navigate("/register")}>Register</button>
        </div>
      </div>
    </>
  );
}
