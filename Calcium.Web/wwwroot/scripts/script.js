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
};

window.DOM = DOM;