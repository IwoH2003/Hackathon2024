import React, { useContext } from "react";
import { AppContext } from "../App";
import "../styles/UserProfiles.css";

function UserProfile() {
  const { userId, username } = useContext(AppContext); // Assume `username` exists in context

  return (
    <div className="user-container">
      <div>Hi {username || "User"}!</div>
      <div
        className="image-wrapper"
        style={{
          backgroundImage: `url(/src/images/tokoniec.jpg)`, // Adjust this path if needed
        }}
      ></div>
    </div>
  );
}

export default UserProfile;
