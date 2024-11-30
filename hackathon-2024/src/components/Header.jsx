import React from "react";
import { Link } from "react-router-dom";
import "../styles/Header.css";

function Header() {
  return (
    <header className="header">
      <div className="header-container">
        {/* H2 as a clickable link */}
        <h2 className="header-logo-h2">
          <Link to="/">Hobbystycznie</Link>
        </h2>
        <nav className="header-nav">
          <ul className="nav-list">
            <li className="nav-item">
              <a href="#about">Ustawienia</a>
            </li>
            <li className="nav-item">
              <a href="#services">Ranking</a>
            </li>
            <li className="nav-item">
              <a href="#contact">Profil</a>
            </li>
          </ul>
        </nav>
      </div>
    </header>
  );
}

export default Header;
