import { useFormik } from "formik";
import * as Yup from "yup";
export default function Ekle() {
  const axios = require("axios");
  const formik = useFormik({
    initialValues: {
      name: "",
      surname: "",
      phoneNumber: "",
      email: "",
      password: "",
    },
    validationSchema: Yup.object({
      name: Yup.string().max(5, "Çok uzun").required("Zorunlu Alan"),
      surname: Yup.string().max(20, "Cok uzun").required("Zorunlu Alan"),
      phoneNumber: Yup.string().required(),
      email: Yup.string().email("Invalid email").required(),
      password: Yup.string().min(6, "Minimum 6 karakter olmalı").required(),
    }),
    onSubmit: (values) => {
      axios.post("https://localhost:44326/api/Users", {
        ...values,
      });
      formik.resetForm();
    },
  });
  return (
    <div>
      <h2>Yeni Kayıt Users</h2>
      <form onSubmit={formik.handleSubmit}>
        <input
          type="text"
          id="name"
          name="name"
          onChange={formik.handleChange}
          value={formik.values.name}
        />
        {formik.errors.name ? <p>{"Name Hata"}</p> : null}
        <input
          type="text"
          id="surname"
          name="surname"
          onChange={formik.handleChange}
          value={formik.values.surname}
        />
        {formik.errors.surname ? <p>{"Surname Hata"}</p> : null}
        <input
          type="text"
          id="phoneNumber"
          name="phoneNumber"
          onChange={formik.handleChange}
          value={formik.values.phoneNumber}
        />
        {formik.errors.phoneNumber ? <p>{"Number Hata"}</p> : null}
        <input
          type="text"
          id="email"
          name="email"
          onChange={formik.handleChange}
          value={formik.values.email}
        />
        {formik.errors.email ? <p>{"Email Hata"}</p> : null}
        <input
          type="text"
          id="password"
          name="password"
          onChange={formik.handleChange}
          value={formik.values.password}
        />
        {formik.errors.password ? <p>{"Password Hata"}</p> : null}
        <button type="submit">Gonder</button>
      </form>
    </div>
  );
}
