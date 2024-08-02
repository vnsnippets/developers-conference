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
        const AnimatedElements = document.querySelectorAll("[data-animate-scroll]");
        AnimatedElements.forEach((element) => AnimateObserver.observe(element));

        console.log(`[${new Date()}] Mutation detected.`);
    });

    DOMObserver.observe(document.querySelector("body"), {
        childList: true,
        subtree: true
    });
})