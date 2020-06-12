module.exports = {
  /*
  ** Headers of the page
  */
  head: {
    title: 'تور خارجی و داخلی - ‌تور های مسافرتی خارجی و داخلی - آژانس علی بابا',
    meta: [
      { charset: 'utf-8' },
      { name: 'viewport', content: 'width=device-width, initial-scale=1' },
      { hid: 'description', name: 'description', content: 'alibaba.ir (web hw)' }
    ],
    link: [
      {
        "rel": "icon",
        "type": "image/png",
        "href": "/images/icon/albb-57x57.png"
      }
    ]
  },
  modules: [
    '@nuxtjs/axios',
  ],
  css:[
    "~/assets/style.css"
  ],
  /*
  ** Customize the progress bar color
  */
  loading: { color: '#3B8070' },
  /*
  ** Build configuration
  */
  build: {
    /*
    ** Run ESLint on save
    */
    extend(config, { isDev, isClient }) {
      if (isDev && isClient) {
        config.module.rules.push({
          enforce: 'pre',
          test: /\.(js|vue)$/,
          loader: 'eslint-loader',
          exclude: /(node_modules)/
        })
      }
    }
  }
}

