import React, { useContext } from "react";
import { AppContext } from "../App";
import "../styles/UserProfiles.css";
import camera from "../images/camera.jpg";

function UserProfile() {
  const { userId, username } = useContext(AppContext); // Assume `username` exists in context

  return (
    <div className="user-container">
      <div>Hi {username || "User"}!</div>
      <div
        className="image-wrapper"
        style={{
          backgroundImage: `url("/src/images/questionmarks.jpg")`,
        }}
      ></div>
    </div>
  );
}

export default UserProfile;
