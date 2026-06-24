import { useState, useEffect } from "react";
import "./Cart_api.js";
import "./Cart_features.js";
import "./Cart_styles.css";

function Cart() {
    return (
        <main className="cart">
            <section className="cart__header">
                1. Page Header

                Simple section containing:

                Cart title
                Number of items

                Example:

                Shopping Cart (4 items)
            </section>

            <section className="cart__">
            </section>


1. Cart Header

Top section.

Contains:

Page title ("Shopping Cart")
Total item count
Optional breadcrumb

Purpose:

Let users know where they are and how many items they have.
2. Cart Items

Core section.

For each item:

Product image
Product name
Product variant (if any)
Unit price
Quantity control
Item subtotal
Remove action

This is where users spend most of their time.

3. Cart Actions

Quick cart management.

Examples:

Continue Shopping
Clear Cart
Update Cart (if applicable)

Keep these secondary to checkout.

4. Order Summary

Purchase overview.

Contains:

Subtotal
Shipping cost
Tax
Discount
Grand Total

Users often look here before proceeding.

5. Coupon / Discount

Optional section.

Contains:

Coupon input
Apply button

Useful if promotions exist in your store.

6. Checkout CTA

Primary action section.

Contains:

Proceed to Checkout button

This should be the most visually prominent action on the page.

7. Empty Cart State

Displayed when no items exist.

Contains:

Empty cart illustration/icon
"Your cart is empty" message
Browse Products button

A dedicated empty state improves UX significantly.
        </main>
    );
};

export default Cart;
