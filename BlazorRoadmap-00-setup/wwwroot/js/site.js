window.site = {
    alert: (msg) => alert(msg),
    viewport: () => ({ w: window.innerWidth, h: window.InnerHeight }),
    focusById: (id) => document.getElementById(id)?.focus()
};

site.scrollPosition = () => ({
    x: window.scrollX,
    y: window.scrollX
});

site.copyToClipboard = (text) => {
  navigator.clipboard.writeText(text);
};
