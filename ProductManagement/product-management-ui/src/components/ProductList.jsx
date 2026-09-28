import { useState, useEffect } from "react";
import productService from "../services/productService";
import ProductForm from "./ProductForm";
import EditProductForm from "./EditProductForm";
import "./ProductList.css";

function ProductList() {
  const [products, setProducts] = useState([]);
  const [category, setCategory] = useState("All");
  const [searchText, setSearchText] = useState("");
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState("");
  const [showAddForm, setShowAddForm] = useState(false);
  const [selectedProduct, setSelectedProduct] = useState(null);
  const [showDeleteModal, setShowDeleteModal] = useState(false);
  const [productToDelete, setProductToDelete] = useState(null);
  const [deleting, setDeleting] = useState(false);

  async function loadProducts() {
    try {
      setLoading(true);
      setError("");
      const data = await productService.getAll();
      setProducts(data);
    } catch (error) {
      setError("Could not load products. Make sure your API is running.");
    } finally {
      setLoading(false);
    }
  }

  useEffect(() => {
    loadProducts();
  }, []);

  const categories = [
    "All",
    ...new Set(products.map((product) => product.category).filter(Boolean)),
  ];

  const filteredProducts = products.filter((product) => {
    const matchesCategory =
      category === "All" || product.category === category;

    const search = searchText.toLowerCase();
    const matchesSearch =
      product.productName?.toLowerCase().includes(search) ||
      String(product.productId).includes(search) ||
      product.category?.toLowerCase().includes(search);

    return matchesCategory && matchesSearch;
  });

  const totalProducts = products.length;
  const totalStock = products.reduce(
    (total, product) => total + Number(product.stockQuantity || 0),
    0
  );
  const lowStockProducts = products.filter(
    (product) => product.stockQuantity < 5
  ).length;
  const totalValue = products.reduce(
    (total, product) =>
      total + Number(product.price || 0) * Number(product.stockQuantity || 0),
    0
  );

  function openDeleteModal(product) {
    setProductToDelete(product);
    setShowDeleteModal(true);
  }

  async function confirmDelete() {
    if (!productToDelete) return;

    try {
      setDeleting(true);
      await productService.delete(productToDelete.productId);
      setShowDeleteModal(false);
      setProductToDelete(null);
      await loadProducts();
    } catch (error) {
      setError("Could not delete product.");
    } finally {
      setDeleting(false);
    }
  }

  function cancelDelete() {
    setShowDeleteModal(false);
    setProductToDelete(null);
  }

  if (selectedProduct) {
    return (
      <div className="page-container">
        <EditProductForm
          product={selectedProduct}
          onCancel={() => setSelectedProduct(null)}
          onProductUpdated={async () => {
            setSelectedProduct(null);
            await loadProducts();
          }}
        />
      </div>
    );
  }

  return (
    <div className="stockora-layout">
      <aside className="sidebar">
        <div className="brand">
          <div className="brand-mark">◇</div>
          <div>
            <h2>Stockora</h2>
            <p>Inventory Management</p>
          </div>
        </div>

        <nav className="sidebar-nav">
          <button className="nav-item active" type="button">
            <span className="nav-icon">⌂</span>
            Dashboard
          </button>
          <button
            className="nav-item"
            type="button"
            onClick={() => document.getElementById("products-section")?.scrollIntoView({ behavior: "smooth" })}
          >
            <span className="nav-icon">▣</span>
            Products
          </button>
        </nav>

        <div className="sidebar-note">
          <div className="sidebar-note-icon">▦</div>
          <h3>Keep your inventory updated</h3>
          <p>Manage products and stock in one place.</p>
          <button
            className="sidebar-add-button"
            onClick={() => setShowAddForm(true)}
            type="button"
          >
            + Add Product
          </button>
        </div>
      </aside>

      <main className="dashboard-main">
        <header className="dashboard-topbar">
          <div className="topbar-search">
            <span>⌕</span>
            <input
              type="text"
              placeholder="Search products..."
              value={searchText}
              onChange={(event) => setSearchText(event.target.value)}
              aria-label="Search products"
            />
          </div>
          <div className="profile">
            <span className="profile-avatar">R</span>
            <span>Revanth Kumar</span>
          </div>
        </header>

        <section className="dashboard-heading">
          <div>
            <h1>Dashboard</h1>
            <p>Manage your products and inventory</p>
          </div>
        </section>

        <section className="summary-cards">
          <article className="summary-card products-card">
            <div className="summary-icon">▣</div>
            <div>
              <p>Total Products</p>
              <h2>{totalProducts.toLocaleString("en-IN")}</h2>
            </div>
          </article>

          <article className="summary-card stock-card">
            <div className="summary-icon">▦</div>
            <div>
              <p>Total Stock</p>
              <h2>{totalStock.toLocaleString("en-IN")}</h2>
            </div>
          </article>

          <article className="summary-card low-stock-card">
            <div className="summary-icon">!</div>
            <div>
              <p>Low Stock Products</p>
              <h2>{lowStockProducts.toLocaleString("en-IN")}</h2>
            </div>
          </article>

          <article className="summary-card value-card">
            <div className="summary-icon">₹</div>
            <div>
              <p>Inventory Value</p>
              <h2>₹ {totalValue.toLocaleString("en-IN")}</h2>
            </div>
          </article>
        </section>

        {error && <p className="error-message">{error}</p>}

        <section className="inventory-section" id="products-section">
          <div className="inventory-header">
            <div>
              <h2>Products</h2>
              <p>Manage all your products here</p>
            </div>

            <div className="filter-area">
              <div className="table-search">
                <span>⌕</span>
                <input
                  type="text"
                  placeholder="Search products..."
                  value={searchText}
                  onChange={(event) => setSearchText(event.target.value)}
                  aria-label="Search product table"
                />
              </div>

              <select
                value={category}
                onChange={(event) => setCategory(event.target.value)}
                aria-label="Filter by category"
              >
                {categories.map((item) => (
                  <option key={item} value={item}>
                    {item === "All" ? "All Categories" : item}
                  </option>
                ))}
              </select>

              <button
                className="add-button"
                onClick={() => setShowAddForm(true)}
                type="button"
              >
                + Add Product
              </button>
            </div>
          </div>

          {loading ? (
            <p className="message">Loading products...</p>
          ) : (
            <div className="table-container">
              <table>
                <thead>
                  <tr>
                    <th>Product ID</th>
                    <th>Product Name</th>
                    <th>Category</th>
                    <th>Price (₹)</th>
                    <th>Stock</th>
                    <th>Status</th>
                    <th>Actions</th>
                  </tr>
                </thead>
                <tbody>
                  {filteredProducts.length === 0 ? (
                    <tr>
                      <td colSpan="7" className="message">
                        No products found.
                      </td>
                    </tr>
                  ) : (
                    filteredProducts.map((product) => {
                      let status = "In Stock";
                      let statusClass = "in-stock";

                      if (product.stockQuantity === 0) {
                        status = "Out of Stock";
                        statusClass = "out-of-stock";
                      } else if (product.stockQuantity < 5) {
                        status = "Low Stock";
                        statusClass = "low-stock";
                      }

                      return (
                        <tr key={product.productId}>
                          <td>{product.productId}</td>
                          <td className="product-name-cell">{product.productName}</td>
                          <td>{product.category}</td>
                          <td>{Number(product.price).toLocaleString("en-IN")}</td>
                          <td>{product.stockQuantity}</td>
                          <td>
                            <span className={`status-badge ${statusClass}`}>
                              {status}
                            </span>
                          </td>
                          <td>
                            <div className="action-buttons">
                              <button
                                className="edit-btn"
                                onClick={() => setSelectedProduct(product)}
                                type="button"
                              >
                                Edit
                              </button>
                              <button
                                className="delete-btn"
                                onClick={() => openDeleteModal(product)}
                                type="button"
                              >
                                Delete
                              </button>
                            </div>
                          </td>
                        </tr>
                      );
                    })
                  )}
                </tbody>
              </table>
            </div>
          )}
        </section>
      </main>

      {showAddForm && (
        <div className="modal-overlay add-product-overlay" role="presentation">
          <section
            className="add-product-modal"
            role="dialog"
            aria-modal="true"
            aria-labelledby="add-product-modal-title"
          >
            <div className="add-product-modal-header">
              <div>
                <span className="modal-eyebrow">STOCKORA INVENTORY</span>
                <h2 id="add-product-modal-title">Add New Product</h2>
                <p>Enter the product details to add it to your inventory.</p>
              </div>
              <button
                className="modal-close-button"
                type="button"
                onClick={() => setShowAddForm(false)}
                aria-label="Close add product form"
              >
                ×
              </button>
            </div>
            <div className="add-product-modal-body">
              <ProductForm
                onCancel={() => setShowAddForm(false)}
                onProductAdded={async () => {
                  setShowAddForm(false);
                  await loadProducts();
                }}
              />
            </div>
          </section>
        </div>
      )}

      {showDeleteModal && productToDelete && (
        <div className="modal-overlay" role="presentation">
          <div
            className="delete-modal"
            role="dialog"
            aria-modal="true"
            aria-labelledby="delete-modal-title"
          >
            <div className="warning-icon">!</div>
            <h2 id="delete-modal-title">Delete Product?</h2>
            <p>
              Are you sure you want to delete{" "}
              <strong>{productToDelete.productName}</strong>?
            </p>
            <p className="modal-note">This action cannot be undone.</p>
            <div className="modal-actions">
              <button
                className="cancel-btn"
                onClick={cancelDelete}
                disabled={deleting}
                type="button"
              >
                Cancel
              </button>
              <button
                className="confirm-delete-btn"
                onClick={confirmDelete}
                disabled={deleting}
                type="button"
              >
                {deleting ? "Deleting..." : "Delete Product"}
              </button>
            </div>
          </div>
        </div>
      )}
    </div>
  );
}

export default ProductList;
