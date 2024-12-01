import React, { useContext } from "react";
import { useNavigate } from "react-router-dom"; // Import useNavigate instead of useHistory
import { useFormik } from "formik";
import { AppContext } from "../App";
import axios from "axios";
import motherAndChild from "../video/motherAndChild.mp4";
import "../styles/RegisterPage.css";

export function Register() {
  const navigate = useNavigate(); // Use useNavigate here
  const { setLogged } = useContext(AppContext);

  const formik = useFormik({
    initialValues: {
      firstName: "",
      lastName: "",
      email: "",
      password: "",
      confirmPassword: "",
    },
    onSubmit: (values) => {
      axios
        .post(
          "https://hackaton2024api.azurewebsites.net/api/account/register",
          {
            firstName: values.firstName,
            lastName: values.lastName,
            email: values.email,
            password: values.password,
            confirmPassword: values.confirmPassword,
          }
        )
        .then((response) => {
          alert("Registration successful!");
          navigate("/login");
        })
        .catch((error) => {
          console.error("Registration failed:", error);
          alert("Registration failed. Please try again.");
        });
    },
  });

  return (
    <div className="register-container">
      {/* Background Video */}
      <video autoPlay loop muted playsInline className="background-video">
        <source src={motherAndChild} type="video/mp4" />
        Your browser does not support the video tag.
      </video>

      {/* Overlay for dimming */}
      <div className="overlay"></div>

      {/* Register Form */}
      <form className="register-form" onSubmit={formik.handleSubmit}>
        <label htmlFor="firstName">First Name</label>
        <input
          id="firstName"
          name="firstName"
          type="text"
          onChange={formik.handleChange}
          value={formik.values.firstName}
        />
        <label htmlFor="lastName">Last Name</label>
        <input
          id="lastName"
          name="lastName"
          type="text"
          onChange={formik.handleChange}
          value={formik.values.lastName}
        />
        <label htmlFor="email">Email</label>
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
        <label htmlFor="confirmPassword">Confirm Password</label>
        <input
          id="confirmPassword"
          name="confirmPassword"
          type="password"
          onChange={formik.handleChange}
          value={formik.values.confirmPassword}
        />
        <button type="submit">Register</button>
      </form>

      {/* Redirect to Login */}
      <div className="content-container">
        <p>Already have an account? Log in below:</p>
        <button onClick={() => navigate("/")}>Login</button>
      </div>
    </div>
  );
}
