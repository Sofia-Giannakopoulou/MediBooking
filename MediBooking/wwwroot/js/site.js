window.collapseNavbar = () => {
    const el = document.getElementById('navbarNav');
    if (!el) return;

    // Bootstrap 5 Collapse instance
    const bsCollapse = bootstrap.Collapse.getInstance(el);

    if (bsCollapse) {
        bsCollapse.hide(); // Collapse the navbar
    }
};

