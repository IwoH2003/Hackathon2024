import React, { useContext } from "react";
import { useNavigate } from "react-router-dom"; // Import useNavigate instead of useHistory
import { useFormik } from "formik";
import { AppContext } from "../App";
import "../styles/LoginPage.css";
export function Register() {
  const navigate = useNavigate(); // Use useNavigate here
  const { logged, setLogged } = useContext(AppContext);
  const formik = useFormik({
    initialValues: {
      username: "",
      password: "",
    },
    onSubmit: (values) => {
      alert(JSON.stringify(values, null, 2));
      setLogged(true);
      navigate("/landingPage"); // Use navigate instead of history.push
    },
  });

  return (
    <div className="content-container">
      <form className="login-form" onSubmit={formik.handleSubmit}>
        <label htmlFor="Email">Email Address</label>
        <input
          id="email"
          name="email"
          type="email"
          onChange={formik.handleChange}
          value={formik.values.email}
        />
        <label htmlFor="Username">Username</label>
        <input
          id="username"
          name="username"
          type="text"
          onChange={formik.handleChange}
          value={formik.values.username}
        />
        <label htmlFor="Password">Password</label>
        <input
          id="password"
          name="password"
          type="password"
          onChange={formik.handleChange}
          value={formik.values.password}
        />

        <button type="submit">Submit</button>
      </form>
      <div>
        <p>If you dont have an account go to register</p>
        <button onClick={() => navigate("/register")}>Register</button>
      </div>
    </div>
  );
}
