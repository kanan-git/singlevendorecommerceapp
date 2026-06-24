import { useState, useEffect } from "react";
import "./Wishlist_api.js";
import "./Wishlist_features.js";
import "./Wishlist_styles.css";

function Wishlist() {
    return (
        <main className="wishlist">
1. Wishlist Header

Top section.

Contains:

Page title ("My Wishlist")
Total saved items count

Purpose:

Show users all products they've saved for later.
2. Wishlist Items

Core section.

For each item:

Product image
Product name
Price
Availability status
Date added (optional)

This is the main content of the page.

3. Wishlist Actions

Item interaction section.

Contains:

Add to Cart
Remove from Wishlist
View Product

Allows users to act on saved products.

4. Bulk Actions (Optional)

Management section.

Contains:

Move All to Cart
Clear Wishlist

Useful when users save many products.

5. Wishlist Sharing (Optional)

Social section.

Contains:

Share Wishlist
Copy Link

Common in larger ecommerce platforms.

6. Recommended Products

Discovery section.

Contains:

Similar Products
You May Also Like

Encourages further browsing.

7. Empty Wishlist State

Shown when no saved products exist.

Contains:

Empty wishlist illustration/icon
"Your wishlist is empty" message
Explore Products button

Prevents the page from feeling unfinished.
        </main>
    );
};

export default Wishlist;
