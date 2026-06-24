import { useState, useEffect } from "react";
import "./Explore_api.js";
import "./Explore_features.js";
import "./Explore_styles.css";

function Explore() {
    return (
        <main className="explore">
1. Explore Header

Top section.

Contains:

Page title ("Explore Products")
Short description
Product count (optional)

Purpose:

Introduce the catalog and help users start browsing.
2. Search Bar

Product discovery section.

Contains:

Search input
Search action

Allows users to quickly find specific products.

3. Filter Panel

Refinement section.

Contains:

Categories
Price range
Brand
Rating
Availability
Other attributes

Helps narrow down large product collections.

4. Sort Options

Organization section.

Examples:

Newest
Price: Low to High
Price: High to Low
Most Popular
Highest Rated

Lets users control product ordering.

5. Active Filters

Feedback section.

Contains:

Applied filter tags
Clear filter action

Makes filtering easier to understand and manage.

6. Product Grid

Core section.

Contains:

Product cards
Product image
Product name
Price
Quick actions

This is the main content of the page.

7. Pagination / Load More

Navigation section.

Contains:

Pagination controls
or
Load More button

Used when product collections become large.

8. Empty Results State

Shown when no products match criteria.

Contains:

No results message
Clear filters action
Return to all products action

Prevents dead ends.

9. Recently Viewed (Optional)

Discovery section.

Contains:

Recently viewed products

Helps users return to products they explored earlier.
        </main>
    );
};

export default Explore;
