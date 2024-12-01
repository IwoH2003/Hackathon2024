import React, { useContext, useEffect, useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import "../styles/Header.css";
import { AppContext } from "../App";

function Header() {
  const { userData } = useContext(AppContext);
  const navigate = useNavigate();
  console.log(userData);
  const handleLogout = () => {
    sessionStorage.removeItem("accessKey");
    sessionStorage.removeItem("id"); // Optionally clear other session data
    setAuthen(false);
    navigate("/"); // Redirect to login page
  };

  return (
    <header className="header">
      <div className="header-container">
        {/* Logo */}
        <h2 className="header-logo-h2">
          <Link to="/">Hobbystycznie</Link>
        </h2>
        <nav className="header-nav">
          <ul className="nav-list">
            <li className="nav-item">
              <Link to="/settings">Ustawienia</Link>
            </li>
            <li className="nav-item">
              <Link to="/ranking">Ranking</Link>
            </li>
            <li className="nav-item">
              <Link to="/user-profile">Profil</Link>
            </li>
            <li className="nav-item">
              {sessionStorage.getItem("accessKey") ? (
                <Link className="auth-button" onClick={() => handleLogout()}>
                  Logout
                </Link>
              ) : (
                <Link className="auth-button" to="/">
                  Login
                </Link>
              )}
            </li>
          </ul>
        </nav>
        {/* Points Display */}
        <div className="points-display">
          🔥 <span className="points">{userData.points || 0}</span>
        </div>
      </div>
    </header>
  );
}

export default Header;
