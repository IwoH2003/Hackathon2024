import React, { useContext, useState } from "react";
import { AppContext } from "../App";
import { useNavigate } from "react-router-dom";
import "../styles/Settings.css";

function Settings() {
  const { theme, setTheme, fontSize, setFontSize } = useContext(AppContext);
  const [localTheme, setLocalTheme] = useState(theme);
  const [localFontSize, setLocalFontSize] = useState(fontSize);
  const navigate = useNavigate();

  const handleSave = () => {
    setTheme(localTheme);
    setFontSize(localFontSize);
    localStorage.setItem("theme", localTheme);
    localStorage.setItem("fontSize", localFontSize);
    navigate("/LandingPage"); // Przekierowanie na stronę profilu użytkownika
  };

  return (
    <div className="settings">
      <h2>Ustawienia</h2>
      <div className="settings-option">
        <label htmlFor="theme-select">Tryb wyświetlania:</label>
        <select
          id="theme-select"
          value={localTheme}
          onChange={(e) => setLocalTheme(e.target.value)}
        >
          <option value="light">Jasny</option>
          <option value="dark">Ciemny</option>
          <option value="high-contrast">Wysoki kontrast</option>
        </select>
      </div>
      <div className="settings-option">
        <label htmlFor="font-size-select">Rozmiar czcionki:</label>
        <select
          id="font-size-select"
          value={localFontSize}
          onChange={(e) => setLocalFontSize(e.target.value)}
        >
          <option value="small">Mały</option>
          <option value="medium">Średni</option>
          <option value="large">Duży</option>
        </select>
      </div>
      <div className="settings-buttons">
        <button onClick={handleSave} className="save-button">
          Zapisz i wróć
        </button>
      </div>
    </div>
  );
}

export default Settings;
