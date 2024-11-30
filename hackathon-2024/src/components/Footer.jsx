import React from "react";
import "../styles/Footer.css";

function Footer() {
  return (
    <footer className="footer">
      <div className="footer-container">
        <p>
          &copy; {new Date().getFullYear()} Hobbystycznie. Wszystkie prawa
          zastrzeżone.
        </p>
        <ul className="footer-links">
          <li>
            <a href="/privacy">Polityka prywatności</a>
          </li>
          <li>
            <a href="/terms">Regulamin</a>
          </li>
          <li>
            <a href="/contact">Kontakt</a>
          </li>
        </ul>
      </div>
    </footer>
  );
}

export default Footer;
