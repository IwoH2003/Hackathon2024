import React from "react";
import { AppContext } from "../App";
import { useContext } from "react";
import "../styles/UserProfiles.css";
function UserProfile() {
  const { userId } = useContext(AppContext);
  return (
    <>
      <div className="user-container">
        <div>Hi username</div>
<<<<<<< HEAD
        <img src={`url("/src/images/tokoniec.jpg")`} />
=======
        <div
          className="image-wrapper"
          style={{
            backgroundImage: `url("/src/images/tokoniec.jpg")`, // Final image
          }}
        ></div>
>>>>>>> origin
      </div>
    </>
  );
}

export default UserProfile;
