import { useState, useEffect } from "react";
import productService from "../services/productService";
import "./ProductForm.css";

function EditProductForm({ product, onProductUpdated, onCancel }) {
  const [productName, setProductName] = useState("");
  const [category, setCategory] = useState("");
  const [price, setPrice] = useState("");
  const [stockQuantity, setStockQuantity] = useState("");
  const [error, setError] = useState("");
  const [loading, setLoading] = useState(false);

  // Put the selected product details into the form
  useEffect(() => {
    setProductName(product.productName);
    setCategory(product.category);
    setPrice(product.price);
    setStockQuantity(product.stockQuantity);
  }, [product]);

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

    if (price === "" || Number(price) <= 0) {
      setError("Price must be greater than zero.");
      return;
    }

    if (stockQuantity === "" || Number(stockQuantity) < 0 ||
        !Number.isInteger(Number(stockQuantity))) {
      setError("Stock must be zero or a positive whole number.");
      return;
    }

    const updatedProduct = {
      productName: productName.trim(),
      category: category,
      price: Number(price),
      stockQuantity: Number(stockQuantity)
    };

    try {
      setLoading(true);
      await productService.update(product.productId, updatedProduct);
      await onProductUpdated();
    } catch (error) {
      setError("Could not update product. Please check whether the API is running.");
    } finally {
      setLoading(false);
    }
  }

  return (
    <div className="form-card">
      <h2>Edit Product</h2>
      <p className="form-description">Change the product details below.</p>

      <form onSubmit={handleSubmit}>
        <label>Product Name</label>
        <input value={productName} onChange={(event) => setProductName(event.target.value)} required />

        <label>Category</label>
        <select value={category} onChange={(event) => setCategory(event.target.value)} required>
          <option value="">Select category</option>
          <option value="Electronics">Electronics</option>
          <option value="Grocery">Grocery</option>
          <option value="Clothing">Clothing</option>
          <option value="Other">Other</option>
        </select>

        <label>Price (₹)</label>
        <input type="number" value={price} onChange={(event) => setPrice(event.target.value)} min="0.01" step="0.01" required />

        <label>Stock Quantity</label>
        <input type="number" value={stockQuantity} onChange={(event) => setStockQuantity(event.target.value)} min="0" step="1" required />

        {error && <p className="form-error">{error}</p>}

        <div className="form-buttons">
          <button type="submit" className="save-button" disabled={loading}>
            {loading ? "Updating..." : "Save Changes"}
          </button>
          <button type="button" className="cancel-button" onClick={onCancel}>
            Cancel
          </button>
        </div>
      </form>
    </div>
  );
}

export default EditProductForm;
