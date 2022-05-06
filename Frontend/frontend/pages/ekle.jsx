import { useFormik } from "formik";
export default function ekle() {
  return (
    <div>
      <h2>Yeni Kayıt</h2>
      <form action="https://localhost:44326/api/Users" method="POST">
        <input type="text" id="Name" />
        <input type="text" id="Surname" />
        <input type="text" id="PhoneNumber" />
        <input type="text" id="Email" />
        <input type="text" id="Password" />
        <input type="text" id="RegisteredAt" />
        <input type="text" id="LastLogin" />

        <input type="submit" value="Ekle" />
      </form>
    </div>
  );
}
