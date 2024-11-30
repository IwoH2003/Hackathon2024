import React from "react";
import "../styles/Ranking.css";

function Ranking() {
  // Mock data for demonstration purposes
  const userRanking = [
    { name: "User1", points: 100 },
    { name: "User2", points: 95 },
    { name: "User3", points: 90 },
    { name: "User4", points: 85 },
    { name: "User5", points: 80 },
    { name: "User6", points: 75 },
    { name: "User7", points: 70 },
    { name: "User8", points: 65 },
    { name: "User9", points: 60 },
    { name: "User10", points: 55 },
  ];

  const friendsRanking = [
    { name: "Friend1", points: 120 },
    { name: "Friend2", points: 110 },
    { name: "Friend3", points: 100 },
    { name: "Friend4", points: 95 },
    { name: "Friend5", points: 90 },
    { name: "Friend6", points: 85 },
    { name: "Friend7", points: 80 },
    { name: "Friend8", points: 75 },
    { name: "Friend9", points: 70 },
    { name: "Friend10", points: 65 },
  ];

  return (
    <div className="ranking-page">
      <div className="ranking-container">
        {/* User Ranking */}
        <div className="ranking-box">
          <h2>Ranking Użytkowników</h2>
          <ul>
            {userRanking.map((user, index) => (
              <li key={index}>
                {index + 1}. {user.name} 🔥 {user.points}
              </li>
            ))}
          </ul>
        </div>

        {/* Friends Ranking */}
        <div className="ranking-box">
          <h2>Ranking Znajomych</h2>
          <ul>
            {friendsRanking.map((friend, index) => (
              <li key={index}>
                {index + 1}. {friend.name} 🔥 {friend.points}
              </li>
            ))}
          </ul>
        </div>
      </div>
    </div>
  );
}

export default Ranking;
