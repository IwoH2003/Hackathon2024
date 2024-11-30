import React from "react";
import "/src/styles/Tutorial.css";

function Drawing() {
  const handleLearned = () => {
    alert("Gratulacje! Nauczyłeś się rysować!");
  };

  return (
    <div className="tutorial-page">
      {/* Transparent Box */}
      <div className="tutorial-container">
        <h1 className="title">Rysowanie - Nauka od podstaw</h1>
        <div className="video-container">
          <iframe
            src="https://www.youtube.com/embed/1jjmOF1hQqI" // Replace with an actual drawing tutorial video URL
            title="Drawing Tutorial"
            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
            allowFullScreen
          ></iframe>
        </div>
        <p className="description">
          Naucz się podstaw rysowania. Rozpocznij swoją przygodę z ołówkiem i
          papierem!
        </p>
        <ul className="steps">
          <li>Przygotuj papier i ołówek.</li>
          <li>Rysuj proste kształty, aby poprawić kontrolę nad ręką.</li>
          <li>Ćwicz cieniowanie i tekstury.</li>
          <li>Znajdź swój styl poprzez codzienną praktykę.</li>
        </ul>
        <button className="learned-button" onClick={handleLearned}>
          Nauczyłem się!
        </button>
      </div>
    </div>
  );
}

export default Drawing;
