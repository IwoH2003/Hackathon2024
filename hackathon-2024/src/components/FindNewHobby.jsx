import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import hobbies from "../data/hobbies";
import "../styles/FindNewHobby.css";

function FindNewHobby() {
  const [remainingHobbies, setRemainingHobbies] = useState([...hobbies]); // Clone the hobbies list
  const [selectedHobby, setSelectedHobby] = useState(null);
  const [isRevealing, setIsRevealing] = useState(false); // State to handle animation
  const navigate = useNavigate();

  console.log(remainingHobbies);
  const handleRandomizeHobby = () => {
    if (remainingHobbies.length === 0) return; // Stop if no hobbies left

    setIsRevealing(true); // Start the animation
    setTimeout(() => {
      const randomIndex = Math.floor(Math.random() * remainingHobbies.length);
      const newHobby = remainingHobbies[randomIndex];
      setSelectedHobby(newHobby);

      // Update remaining hobbies
      const updatedHobbies = [...remainingHobbies];
      updatedHobbies.splice(randomIndex, 1); // Remove the selected hobby by index
      setRemainingHobbies(updatedHobbies);

      setIsRevealing(false); // End the animation
    }, 1000); // Match the animation duration in CSS
  };

  return (
    <div className="find-new-hobby">
      <div className="content-box">
        <h1>Znajdź nowe hobby</h1>
        <div className="hobby-container">
          {remainingHobbies.length > 0 ? (
            <div
              className={`image-wrapper ${isRevealing ? "fade-out" : "fade-in"}`}
              style={{
                backgroundImage: `url(${
                  selectedHobby
                    ? selectedHobby.image
                    : "/src/images/questionmarks.jpg"
                })`,
              }}
            />
          ) : (
            <div
              className="image-wrapper"
              style={{
                backgroundImage: `url("/src/images/tokoniec.jpg")`,
              }}
            >
              <p className="end-message">
                Wylosowałeś wszystkie dostępne hobby!
              </p>
            </div>
          )}
          {selectedHobby && remainingHobbies.length > 0 && (
            <>
              <h2>{selectedHobby.name}</h2>
              <p>{selectedHobby.description}</p>
              <button
                className="randomize-button"
                onClick={() => navigate(selectedHobby.tutorialPath)}
              >
                Zacznij się uczyć
              </button>
            </>
          )}
        </div>
        {remainingHobbies.length > 0 && (
          <button className="randomize-button" onClick={handleRandomizeHobby}>
            Losuj hobby
          </button>
        )}
      </div>
    </div>
  );
}

export default FindNewHobby;
