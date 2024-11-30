import React, { createContext, useEffect, useState } from "react";
import { Routes, Route } from "react-router-dom";
import Header from "./components/Header";
import LandingPage from "./components/LandingPage";
import { Login } from "./components/Login";
import FindNewHobby from "./components/FindNewHobby";
import UserProfile from "./components/UserProfile";
import Footer from "./components/Footer";
import { Register } from "./components/Register";
import Settings from "./components/Settings";
import Ranking from "./components/Ranking";
import "./index.css";
import Cooking from "./components/tutorials/Cooking";
import Drawing from "./components/tutorials/Drawing";
import Photography from "./components/tutorials/Photography";

export const AppContext = createContext();

function App() {
  const [logged, setLogged] = useState(false);
  const [userId, setUserId] = useState(1);
  const [theme, setTheme] = useState("light");
  const [fontSize, setFontSize] = useState("medium");

  useEffect(() => {
    if (sessionStorage.getItem("accessKey")) {
      setLogged(true);
    }
  });

  useEffect(() => {
    const jwt = sessionStorage.getItem("accessKey");
    ifLogged(jwt);
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
        <Route path="/ranking" element={<Ranking />} />
        <Route path="/find-hobby" element={<FindNewHobby />} />
        <Route path="/user-profile" element={<UserProfile />} />
        <Route path="/tutorial/drawing" element={<Drawing />} />
        <Route path="/tutorial/cooking" element={<Cooking />} />
        <Route path="/tutorial/photography" element={<Photography />} />
      </Routes>
      <Footer />
    </AppContext.Provider>
  );
}

export default App;
