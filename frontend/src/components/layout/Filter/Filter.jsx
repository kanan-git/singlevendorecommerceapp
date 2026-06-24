import { useState, useEffect } from "react";
import "./Filter_features.js";
import "./Filter_styles.css";

function Filter() {
    return (
        <aside className="filter">
1. Filter Header

Top section of sidebar.

Contains:

Title ("Filters")
Clear All button

Purpose:

Let users reset all applied filters quickly
2. Category Filter

Main grouping filter.

Contains:

List of categories (checkbox or radio)
Expand/collapse (optional if many categories)

Purpose:

Let users browse by product type
3. Price Range Filter

Numeric filter section.

Contains:

Min price input / slider
Max price input / slider

Purpose:

Control budget-based filtering
4. Brand Filter (Optional)

If your products have brands.

Contains:

List of brands (checkboxes)
Search inside brands (optional for large lists)

Purpose:

Filter by manufacturer or label
5. Rating Filter (Optional)

Quality-based filter.

Contains:

Star rating options (e.g. 4★ & above)

Purpose:

Show only higher-rated products
6. Availability Filter

Stock status filter.

Contains:

In Stock
Out of Stock (optional toggle)

Purpose:

Avoid unavailable items
7. Other Attributes (Optional)

Flexible filter section depending on product type.

Examples:

Color
Size
Material
Gender
Tags

Purpose:

Domain-specific filtering
8. Apply Filters Button (Optional)

Control section (depends on design choice).

Two common approaches:

Auto-apply filters (no button needed)
Manual apply button

Purpose:

Apply selected filters to product grid
9. Mobile Behavior (Important)

On mobile, sidebar becomes:

Slide-in drawer OR
Collapsible panel

Includes:

Close button
Apply button (if not auto-applied)
        </aside>
    );
};

export default Filter;
