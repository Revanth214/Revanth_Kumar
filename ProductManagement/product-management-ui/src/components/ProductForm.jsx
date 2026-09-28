import { useState } from "react";
import productService from "../services/productService";
import "./ProductForm.css";

function ProductForm({ onProductAdded, onCancel }) {
  const [productName, setProductName] = useState("");
  const [category, setCategory] = useState("");
  const [price, setPrice] = useState("");
  const [stockQuantity, setStockQuantity] = useState("");
  const [error, setError] = useState("");
  const [loading, setLoading] = useState(false);

  async function handleSubmit(event) {
    event.preventDefault();
    setError("");

    if (productName.trim() === "") {
      setError("Please enter the product name.");
      return;
    }

    if (category === "") {
      setError("Please select a category.");
      return;
    }

    if (Number(price) <= 0 || price === "") {
      setError("Price must be greater than zero.");
      return;
    }

    if (stockQuantity === "" || Number(stockQuantity) < 1 ||
        !Number.isInteger(Number(stockQuantity))) {
      setError("Stock must be a positive whole number.");
      return;
    }

    const newProduct = {
      productName: productName.trim(),
      category: category,
      price: Number(price),
      stockQuantity: Number(stockQuantity)
    };

    try {
      setLoading(true);
      await productService.create(newProduct);

      setProductName("");
      setCategory("");
      setPrice("");
      setStockQuantity("");

      await onProductAdded();
      if (onCancel) {
        onCancel();
      }
    } catch (error) {
      setError("Could not add product. Please check whether the API is running.");
    } finally {
      setLoading(false);
    }
  }

  return (
    <div className="form-card">
      <h2>Add Product</h2>
      <p className="form-description">Enter the details of the new product.</p>

      <form onSubmit={handleSubmit}>
        <label>Product Name</label>
        <input
          type="text"
          value={productName}
          onChange={(event) => setProductName(event.target.value)}
          placeholder="Enter product name"
          required
        />

        <label>Category</label>
        <select value={category} onChange={(event) => setCategory(event.target.value)} required>
          <option value="">Select category</option>
          <option value="Electronics">Electronics</option>
          <option value="Grocery">Grocery</option>
          <option value="Clothing">Clothing</option>
          <option value="Other">Other</option>
        </select>

        <label>Price (₹)</label>
        <input
          type="number"
          value={price}
          onChange={(event) => setPrice(event.target.value)}
          min="0.01"
          step="0.01"
          placeholder="Enter price"
          required
        />

        <label>Stock Quantity</label>
        <input
          type="number"
          value={stockQuantity}
          onChange={(event) => setStockQuantity(event.target.value)}
          min="0"
          step="1"
          placeholder="Enter quantity"
          required
        />

        {error && <p className="form-error">{error}</p>}

        <div className="form-buttons">
          <button type="submit" className="save-button" disabled={loading}>
            {loading ? "Saving..." : "Add Product"}
          </button>
          {onCancel && (
            <button type="button" className="cancel-button" onClick={onCancel}>
              Cancel
            </button>
          )}
        </div>
      </form>
    </div>
  );
}

export default ProductForm;
