import axios from "axios";

// URL of your ASP.NET Core Web API
const API_URL = "https://localhost:7187/api/products";

// Functions used to communicate with the API
const productService = {
  // Get all products
  getAll: async function () {
    const response = await axios.get(API_URL);
    return response.data;
  },

  // Add a new product
  create: async function (product) {
    const response = await axios.post(API_URL, product);
    return response.data;
  },

  // Update an existing product
  update: async function (id, product) {
    const response = await axios.put(API_URL + "/" + id, product);
    return response.status;
  },

  // Delete a product
  delete: async function (id) {
    const response = await axios.delete(API_URL + "/" + id);
    return response.status;
  }
};

export default productService;
