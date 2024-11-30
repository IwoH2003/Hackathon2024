import React, { createContext, useEffect, useState } from "react";
import { Routes, Route } from "react-router-dom";
import { jwtDecode } from "jwt-decode"; // Import jwt-decode
import Header from "./components/Header";
import LandingPage from "./components/LandingPage";
import { Login } from "./components/Login";
import FindNewHobby from "./components/FindNewHobby";
import UserProfile from "./components/UserProfile";
import Footer from "./components/Footer";
import { Register } from "./components/Register";
import Settings from "./components/Settings";
import "./index.css";

export const AppContext = createContext();

function App() {
  const [logged, setLogged] = useState(false);
  const [userId, setUserId] = useState(1);
  const [theme, setTheme] = useState("light");
  const [fontSize, setFontSize] = useState("medium");

  useEffect(() => {
    // Check if the access token exists
    const jwt = sessionStorage.getItem("accessKey");
    if (jwt) {
      setLogged(true);

      try {
        // Decode the JWT
        const decodedToken = jwtDecode(jwt);
        console.log("Decoded JWT:", decodedToken);

        // Optional: Update userId or other state from the token
        if (decodedToken.userId) {
          setUserId(decodedToken.userId);
          console.log(userId);
          console.log("CHUJJJJJ");
        }
      } catch (error) {
        console.error("Invalid JWT:", error);
      }
    }
  }, []);

  useEffect(() => {
    document.body.className = ""; // Reset classes
    document.body.classList.add(theme);
    document.body.style.setProperty(
      "--font-size",
      fontSize === "small" ? "14px" : fontSize === "large" ? "26px" : "16px"
    );
  }, [theme, fontSize]);

  return (
    <AppContext.Provider
      value={{
        userId,
        setUserId,
        logged,
        setLogged,
        theme,
        setTheme,
        fontSize,
        setFontSize,
      }}
    >
      <Header />
      <Routes>
        <Route path="/" element={<Login />} />
        <Route path="/landingPage" element={<LandingPage />} />
        <Route path="/about" element={<h1>About Page</h1>} />
        <Route path="/settings" element={<Settings />} />
        <Route path="/register" element={<Register />} />
        <Route path="/find-hobby" element={<FindNewHobby />} />
        <Route path="/user-profile" element={<UserProfile />} />
        <Route
          path="/tutorial/photography"
          element={<h1>Fotografia Tutorial</h1>}
        />
        <Route path="/tutorial/drawing" element={<h1>Rysowanie Tutorial</h1>} />
        <Route path="/tutorial/cooking" element={<h1>Gotowanie Tutorial</h1>} />
      </Routes>
      <Footer />
    </AppContext.Provider>
  );
}

export default App;
