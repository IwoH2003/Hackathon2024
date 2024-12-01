import "../styles/LandingPage.css";
import { useNavigate } from "react-router-dom";
import skateboard from "../video/skateboard.mp4"; // Import wideo jako tło
import { AppContext } from "../App";
import { useContext, useEffect } from "react";

import axios from "axios";

function LandingPage() {
  const { logged, userId, userData, setUserData } = useContext(AppContext);
  useEffect(() => {
    const id = sessionStorage.getItem("id");
    if (id) {
      axios
        .get(`https://hackaton2024api.azurewebsites.net/api/users/${id}`)
        .then((response) => {
          sessionStorage.setItem("data", JSON.stringify(response.data)); // Save to sessionStorage

          // Create the object with all fields from the API response
          const obj = {
            firstName: response.data.firstName,
            lastName: response.data.lastName,
            email: response.data.email,
            points: response.data.points || 0, // Default points to 0 if missing
            activities: response.data.activities || [], // Ensure activities is always an array
          };

          // Update the userData state with the complete object
          setUserData(obj);
        })
        .catch((error) => {
          console.error("Error fetching user data", error);
        });
    }
  }, []);
  const navigate = useNavigate();
  return (
    <div className="landing-page">
      {/* Background Video */}
      <video autoPlay loop muted playsInline className="background-video">
        <source src={skateboard} type="video/mp4" />
        Your browser does not support the video tag.
      </video>

      {/* Overlay for dimming */}
      <div className="overlay"></div>

      {/* Content Container */}
      <div className="content-container">
        <h1 className="title">Witaj w Hobby Finder!</h1>
        <p className="description">
          Odkryj swoje nowe hobby! Nasza aplikacja pomoże Ci znaleźć zajęcia,
          które pasują do Twoich możliwości i zainteresowań. Zdobywaj punkty,
          rywalizuj ze znajomymi i baw się świetnie!
        </p>
        <button
          className="start-quiz-btn"
          onClick={() => navigate("/find-hobby")}
        >
          Wylosuj hobby
        </button>
      </div>
    </div>
  );
}

export default LandingPage;
