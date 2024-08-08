export class DOM {
    static AnimationObserver;

    static ObserveForAnimations = () => {
        var AnimatedElements = document.querySelectorAll("[data-animate-scroll]");

        this.AnimationObserver = new IntersectionObserver(entries => {
            entries.forEach((entry) => {
                if (entry.isIntersecting) {
                    var element = entry.target;
                    element.classList.add(element.getAttribute("data-animate-scroll"));
                }
            });
        });

        AnimatedElements.forEach((element) => this.AnimationObserver.observe(element));
    }

    static FileDownload = (filename, contentType, content) => {
        // Create the URL
        const file = new File([content], filename, { type: contentType });
        const exportUrl = URL.createObjectURL(file);

        // Create the <a> element and click on it
        const a = document.createElement("a");
        document.body.appendChild(a);
        a.href = exportUrl;
        a.download = filename;
        a.target = "_self";
        a.click();

        // We don't need to keep the object URL, let's release the memory
        // On older versions of Safari, it seems you need to comment this line...
        URL.revokeObjectURL(exportUrl);
    }

    static StartTestimonialsAnimation = () => {
        const Animate = () => {
            const carousel = document.querySelector(".testimonials");
            const cardwidth = carousel.children[0].offsetWidth;

            const cards = [...carousel.children];
            
            // Number of cards per view
            // After scrolling, the cards in view can be added to the end of the container
            let cardsperview = Math.round(carousel.offsetWidth / cardwidth);

            for (var i = 0; i < cardsperview; i++) {
                if (carousel.children[i]) {
                    carousel.insertAdjacentHTML("beforeend", carousel.children[i].outerHTML)
                }
            }

            carousel.scrollLeft += (cardwidth * cardsperview) + (16 * cardsperview - 1);
            
            //for (var i = 0; i < cardsperview; i++) {
            //    carousel.removeChild(carousel.firstChild);
            //}
        }

        window.setInterval(Animate, 5000);
    }
};

window.DOM = DOM;