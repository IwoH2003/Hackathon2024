import React from "react";
import { Link } from "react-router-dom";
import "../styles/Header.css";

function Header() {
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
          </ul>
        </nav>
        {/* Points Display */}
        <div className="points-display">
          🔥 <span className="points">0</span>
        </div>
      </div>
    </header>
  );
}

export default Header;
