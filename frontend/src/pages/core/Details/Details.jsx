import { useState, useEffect } from "react";
import "./Details_api.js";
import "./Details_features.js";
import "./Details_styles.css";

function Details() {
    return (
        <main className="details">
1. Product Overview

Main section.

Contains:

Product images/gallery
Product name
Price
Short description
Availability/stock status

This is the first thing users focus on.

2. Product Actions

Purchase interaction section.

Contains:

Quantity selector
Add to Cart button
Add to Wishlist button

Primary actions related to the product.

3. Product Information

Detailed product description.

Contains:

Full description
Features
Benefits
Important notes

Helps users understand the product before buying.

4. Specifications

Technical/product details section.

Examples:

Brand
Material
Dimensions
Weight
Color options
Other attributes

Usually displayed as a table or list.

5. Product Media

Additional visual content.

Contains:

Extra images
Product videos (optional)
Zoomable gallery (optional)

Improves product presentation.

6. Customer Reviews

Feedback section.

Contains:

Ratings
Reviews
Review count

One of the most important trust-building areas.

7. Related Products

Discovery section.

Examples:

Similar Products
You May Also Like
Customers Also Viewed

Helps users continue shopping.

8. Shipping & Returns

Purchase information section.

Contains:

Shipping information
Delivery estimates
Return policy summary

Answers common pre-purchase questions.

9. Questions & Answers (Optional)

Community/support section.

Contains:

Product questions
Answers

Useful for a more advanced ecommerce experience.
        </main>
    );
};

export default Details;
