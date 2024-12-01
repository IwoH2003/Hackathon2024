import React, { useContext, useEffect } from "react";
import { AppContext } from "../App";
import "../styles/UserProfiles.css";
import axios from "axios";

function UserProfile() {
  const { userData, setUserData } = useContext(AppContext);

  // Enum to map activity stages to descriptive labels
  const ActivityStage = {
    0: "Unfinished",
    1: "Completed",
  };

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
  }, [setUserData]);
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
          <h2>Welcome, {`${userData.firstName} ${userData.lastName}`}</h2>
          <p>Email: {userData.email}</p>
          <p>Points: {userData.points}</p>
          <p>
            Here's your summary. You can update your profile and check your
            activities below.
          </p>
        </div>
      </div>

      {/* Center Section: Title */}
      <h1 className="activities-title">Your Activities</h1>

      {/* Bottom Section: Activities */}
      <div className="activities-section">
        {userData.activities.length > 0 ? (
          userData.activities.map((activity, index) => (
            <div key={index} className="activity-item">
              <h3>{activity.name}</h3>
              <p>Stage: {ActivityStage[activity.stage]}</p>
            </div>
          ))
        ) : (
          <p>No activities yet. Start something new!</p>
        )}
      </div>
    </div>
  );
}

export default UserProfile;
