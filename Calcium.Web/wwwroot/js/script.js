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
    });

    DOMObserver.observe(document.querySelector("body"), {
        childList: true,
        subtree: true
    });

    
})
window.FileDownload = (filename, contentType, content) => {
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