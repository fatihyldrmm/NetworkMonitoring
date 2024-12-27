/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './wwwroot/**/*.html',
        './Pages/**/*.razor',
        './Components/**/*.razor',
        './Shared/**/*.razor',
        'node_modules/flowbite/**/*.js',
    ],
    theme: {
        extend: {},
    },
    plugins: [],
    darkMode: 'class'
};
