import useSWR from "swr";
const fetcher = (...args) => fetch(...args).then((res) => res.json());
export default function Home() {
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
