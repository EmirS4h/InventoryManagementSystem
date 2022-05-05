import useSWR from "swr";
const fetcher = (...args) => fetch(...args).then((res) => res.json());
export default function Home() { v
  const { data, error } = useSWR(
    "https://localhost:44326/WeatherForecast/listem",
    fetcher
  );
  return (
    <div className="w-2/4 flex flex-row flex-wrap p-5 align-middle justify-around gap-2 m-auto">
      {data ? data.map((project) => {
        return (
          <div key={project.id} className="w-1/4 h-52 p-2 border-2 border-black rounded-md shadow-lg">
            <h2>{project.projectName}</h2>
          </div>
        );
      }) : "Yükleniyor"}
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