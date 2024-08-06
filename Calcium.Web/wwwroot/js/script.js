document.addEventListener("DOMContentLoaded", () => {
    const AnimateObserver = new IntersectionObserver(entries => {
        entries.forEach((entry) => {
            if (entry.isIntersecting) {
                var element = entry.target;
                element.classList.add(element.getAttribute("data-animate-scroll"));

                console.log(`[${new Date()}] Animation triggered for ${element}.`);
            }
        });
    });

    const DOMObserver = new MutationObserver(() => {
        console.log(`[${new Date()}] Mutation detected.`);

        const AnimatedElements = document.querySelectorAll("[data-animate-scroll]");
        AnimatedElements.forEach((element) => AnimateObserver.observe(element));

        var easterEgg = 0;

        //document.querySelector("[data-easter-egg]").addEventListener("click", () => {
        //    easterEgg++;

        //    if (easterEgg >= 5) {
        //        if (document.querySelector("html").dataset.theme == "dark")
        //            document.querySelector("html").dataset.theme = "light"
        //        else document.querySelector("html").dataset.theme = "dark"

        //        easterEgg = 0;
        //    }

        //    setTimeout(() => {
        //        easterEgg = 0;
        //    }, 2000);
        //})
    });

    DOMObserver.observe(document.querySelector("body"), {
        childList: true,
        subtree: true
    });
})