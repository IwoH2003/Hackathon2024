import React from "react";
import "/src/styles/Tutorial.css";

function Photography() {
  const handleLearned = () => {
    alert("Gratulacje! Nauczyłeś się podstaw fotografii!");
  };

  return (
    <div className="tutorial-page">
      {/* Transparent Box */}
      <div className="tutorial-container">
        <h1 className="title">Fotografia - Nauka od podstaw</h1>
        <div className="video-container">
          <iframe
            src="https://www.youtube.com/embed/V7z7BAZdt2M" // Replace with an actual photography tutorial video URL
            title="Photography Tutorial"
            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
            allowFullScreen
          ></iframe>
        </div>
        <p className="description">
          Poznaj podstawy fotografii, od ustawień aparatu po kompozycję i
          światło!
        </p>
        <ul className="steps">
          <li>Poznaj ustawienia aparatu: ISO, przysłona, czas naświetlania.</li>
          <li>Zwróć uwagę na światło i cień.</li>
          <li>Eksperymentuj z różnymi kompozycjami.</li>
          <li>Praktykuj w różnych warunkach oświetleniowych.</li>
        </ul>
        <button className="learned-button" onClick={handleLearned}>
          Nauczyłem się!
        </button>
      </div>
    </div>
  );
}

export default Photography;
