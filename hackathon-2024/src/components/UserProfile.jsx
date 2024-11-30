import React from "react";
import { AppContext } from "../App";
import { useContext } from "react";
function UserProfile() {
  const { userId } = useContext(AppContext);
  return (
    <>
      <div className="user-container">
        <div>Hi username</div>
        <img src={`url("/src/images/tokoniec.jpg")`} />
      </div>
    </>
  );
}

export default UserProfile;
