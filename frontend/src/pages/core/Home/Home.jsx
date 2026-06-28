import { useState, useEffect, useMemo } from "react";
import { Link } from "react-router-dom";
import ProductCard from "../../../components/custom/ProductCard/ProductCard.jsx";
import fakeDbProducts from "../../../assets/utils/tempFakeDatabase/products.js";
import icons from "../../../assets/utils/constants/bootstrapIcons.js";
import "./Home_api.js";
import "./Home_features.js";
import "./Home_styles.css";

function Home() {
    const [offerProducts, setOfferProducts] = useState([]);

    function createOfferSlides(products) {
        const slides = [];
        for(let i=0; i<2; i++) {
            slides.push(
                <div className="home__limitedoffer-item" key={`offerslide_${i}`}>
                    {createOfferSlideCards(products, i)}
                </div>
            );
        };
        return slides;
    };
    function createOfferSlideCards(data, lastIndex) {
        const cards = [];
        for(let i=lastIndex*4; i<lastIndex*4+4; i++) {
            cards.push(<ProductCard key={`limited_pc_${i}`} serial="home_spec" data={data[i]} />);
        };
        return cards;
    };

    useEffect(() => {
        const newArray = [];
        for(let i=0; i<8; i++) {
            newArray.push(fakeDbProducts[i]);
        };
        setOfferProducts(prev => [...prev, ...newArray]);
    }, []);

    return (
        <main className="home">
            {/* <section className="home__hero">
                homepage hero
                carousel cta
            </section> */}

            <section className="home__limitedoffer">
                <Link className="home__limitedoffer-header" to="/explore?item=special">
                    <h2>Limited Time Offer</h2>
                    <button>
                        <span>Show More</span>
                        <i className={icons.carousel.next}></i>
                    </button>
                </Link>

                <div className="home__limitedoffer-container">
                    <button>
                        <i className={icons.carousel.prev}></i>
                    </button>

                    <div className="home__limitedoffer-slide">
                        {offerProducts.length > 0 && createOfferSlides(offerProducts)}
                    </div>

                    <button>
                        <i className={icons.carousel.next}></i>
                    </button>
                </div>
            </section>

            {/* <section className="home__whyus">
                homepage whyus
                little info and about page link
            </section> */}

            {/* <section className="home__categories">
                homepage categories
                category cards with interactive effect
            </section> */}

            {/* <section className="home__trending">
                homepage trending
                header and trend 20 productcard then show more btn
            </section> */}

            {/* <section className="home__brands">
                homepage brands
                brand cards with draggable carousel in infinite auto slow scroll
            </section> */}
        </main>
    );
};

export default Home;
