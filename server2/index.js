const express = require("express");
const cors = require("cors");
const app = express();

app.use(express.json());
app.use(cors());

const db = require("./models");

const toDoRouter = require("./routes/ToDos");

app.use("/ToDos", toDoRouter);

const UsersRouter = require("./routes/Users");

app.use("/auth", UsersRouter);

const ListsRouter = require("./routes/ToDoLists");

app.use("/list", ListsRouter);
db.sequelize.sync().then(() => {
  app.listen(5000, () => [console.log(`Server running on port 5000`)]);
});
