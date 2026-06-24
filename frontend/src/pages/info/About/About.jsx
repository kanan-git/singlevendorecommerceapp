import { useState, useEffect } from "react";
import "./About_api.js";
import "./About_features.js";
import "./About_styles.css";

function About() {
    return (
        <main className="about">
            <section className="about__hero">
                1. About Hero

                Top section.

                Contains:

                Page title ("About Us")
                Short introduction
                Relevant image/banner

                Example content idea:

                We're dedicated to providing quality products, secure shopping, and excellent customer experience.
            </section>

            <section className="about__story">
                2. Our Story

                The core section.

                Talk about:

                Why the store exists
                How it started
                What problem it solves

                Keep it short. Most users skim.

                Possible structure:

                Beginning
                Mission
                Current state
            </section>

            <section className="about__mission">
                3. Our Mission & Values

                Separate cards or columns.

                Examples:

                Quality
                Customer Satisfaction
                Transparency
                Reliability
                Innovation

                This section makes the business feel more legitimate.
            </section>

            <section className="about__whyshopwithus">
                4. Why Shop With Us

                This is one of the most useful sections.

                Could include:

                Secure payments
                Fast shipping
                Easy returns
                Carefully selected products
                Customer support

                Essentially a more detailed version of the homepage trust section.
            </section>

            <section className="about__statistics">
                5. By The Numbers

                Adds credibility.

                Examples:

                Products available
                Orders delivered
                Happy customers
                Years in business

                Even if data is dynamic later, the section itself is valuable.
            </section>

            <section className="about__team">
                6. Meet The Team (Optional)

                For a small project:

                Founder card
                Team member cards

                For a fictional/demo store:

                Can be omitted entirely.

                Many real ecommerce sites don't have this.
            </section>

            <section className="about__reviews">
                7. Customer Testimonials

                A few featured reviews.

                This works well on About because visitors are already evaluating trust.
            </section>

            <section className="about__cta">
                8. Call To Action

                End the page with a direction.

                Examples:

                Explore Products
                Start Shopping
                Browse Categories

                Never let the page simply end after the content.
            </section>
        </main>
    );
};

export default About;
