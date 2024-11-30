import React, { useContext } from "react";
import { AppContext } from "../App";
import "../styles/UserProfiles.css";
import camera from "../images/camera.jpg";

function UserProfile() {
  const { username } = useContext(AppContext); // Assume `username` exists in context

  return (
    <div className="user-container">
      {/* Top Section: User Photo and Summary */}
      <div className="top-section">
        <div
          className="image-wrapper user-photo"
          style={{
            backgroundImage: `url("/src/images/questionmarks.jpg")`,
          }}
        ></div>
        <div className="users-summary">
          <h2>Welcome, {username || "User"}!</h2>
          <p>
            Here's your summary. You can update your profile and check your
            activities below.
          </p>
        </div>
      </div>

      {/* Center Section: Title */}
      <h1 className="activities-title">Your Activities</h1>

      {/* Bottom Section: Activity Images */}
      <div className="activities-section">
        <button className="scroll-button">{"<"}</button>
        <div className="activities">
          <div
            className="image-wrapper"
            style={{
              backgroundImage: `url("/src/images/questionmarks.jpg")`,
            }}
          ></div>
          <div
            className="image-wrapper"
            style={{
              backgroundImage: `url("/src/images/camera.jpg")`,
            }}
          ></div>
          <div
            className="image-wrapper"
            style={{
              backgroundImage: `url("/src/images/questionmarks.jpg")`,
            }}
          ></div>
        </div>
        <button className="scroll-button">{">"}</button>
      </div>
    </div>
  );
}

export default UserProfile;
