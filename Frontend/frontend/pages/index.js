import useSWR from "swr";
const fetcher = (...args) => fetch(...args).then((res) => res.json());
export default function Home() {
  const axios = require("axios");

  const { data, error } = useSWR("https://localhost:44326/api/Users", fetcher);
  const handleClick = (id) => {
    axios.delete("https://localhost:44326/api/Users/" + id, {});
  };
  return (
    <div className="w-2/4 flex flex-row flex-wrap p-5 align-middle justify-around gap-2 m-auto">
      {data
        ? data.map((project) => {
            return (
              <div
                key={project.id}
                className="w-1/4 h-52 p-2 border-2 border-black rounded-md shadow-lg"
              >
                <h2>{project.name}</h2>
                <button className="px-8 py-2 rounded shadow-md bg-red-500 text-white" onClick={() => handleClick(project.id)}>Sil</button>
              </div>
            );
          })
        : "Yükleniyor"}
    </div>
  );
}

// CREATE TABLE "Todos" (
// 	"Id"	INTEGER NOT NULL UNIQUE,
// 	"TodoText"	TEXT NOT NULL,
// 	"Completed"	INTEGER NOT NULL DEFAULT 0,
// 	"CreatedDate"	TEXT NOT NULL,
// 	"UpdatedDate"	TEXT,
// 	"CompletedDate"	TEXT,
// 	"Priority"	TEXT NOT NULL,
// 	"ProjectId"	INTEGER NOT NULL,
// 	FOREIGN KEY("ProjectId") REFERENCES "Projects"("Id") ON DELETE CASCADE,
// 	PRIMARY KEY("Id" AUTOINCREMENT)
// );
