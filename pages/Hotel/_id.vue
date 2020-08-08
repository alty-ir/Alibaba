<template>
  <div>
    <main class="inh-main p-hotel-detail bg-gray" data-v-21eb7522>
      <div class="container hotel-detail-container" data-v-21eb7522>
        <div class="hidden-xs mt-2 mb-3-sm mb-0-md" data-v-21eb7522>
          <ol
            aria-label="breadcrumbs"
            class="common-breadcrumbs p-0 m-0"
            data-v-085350a8
            data-v-21eb7522
          >
            <li class="common-breadcrumbs__breadcrumb" data-v-085350a8>
              <a href="/hotel" rel class="nuxt-link-active" data-v-085350a8>رزرو هتل</a>
            </li>
            <li aria-hidden="true" class="common-breadcrumbs__seperator" data-v-085350a8>/</li>
            <li class="common-breadcrumbs__breadcrumb" data-v-085350a8>
              <a
                href="/hotel/search/results?countryCode=TR&amp;region=int&amp;destination=City_924_%D8%A7%D8%B3%D8%AA%D8%A7%D9%86%D8%A8%D9%88%D9%84&amp;rooms=30,30_&amp;departing=2020-06-07&amp;returning=2020-06-09"
                rel="nofollow"
                data-v-085350a8
                class
              >هتل&zwnj;های {{hotel.city}}</a>
            </li>
            <li aria-hidden="true" class="common-breadcrumbs__seperator" data-v-085350a8>/</li>
            <li
              class="common-breadcrumbs__breadcrumb common-breadcrumbs__breadcrumb--active"
              data-v-085350a8
            >
              <span data-v-085350a8>{{hotel.name}}</span>
            </li>
            <!---->
          </ol>
        </div>
        <div class="row" data-v-21eb7522>
          <div class="hidden-xs hidden-sm col-xs-12 text-right" data-v-21eb7522>
            <div class="hotel-detail-title" data-v-21eb7522>
              <h2 class="hotel-detail-title-name m-0 inline-block ml-2 font-en ltr">{{hotel.name}}</h2>
              <div class="rate-stars inline-block" data-v-02a24b22>
                <i class="icon-star-rate active" data-v-02a24b22></i>
                <i class="icon-star-rate active" data-v-02a24b22></i>
                <i class="icon-star-rate active" data-v-02a24b22></i>
                <i class="icon-star-rate active" data-v-02a24b22></i>
                <i class="icon-star-rate active" data-v-02a24b22></i>
              </div>
              <div>
                <div class="inline-block">
                  <a
                    href="#poi-section"
                    class="text-dark font-en"
                  >{{hotel.address}}</a>
                  <a href="#poi-section" class="btn btn-link text-blue">
                    <span class="hotel-detail-pin">
                      <svg
                        xmlns:xlink="http://www.w3.org/1999/xlink"
                        height="18px"
                        width="14px"
                        fill
                        xmlns="http://www.w3.org/2000/svg"
                        version="1.1"
                        viewBox="0 0 14 18"
                        class="svg-icon"
                      >
                        <g
                          id="point-of-interest"
                          stroke="none"
                          stroke-width="1"
                          fill="none"
                          fill-rule="evenodd"
                        >
                          <g
                            id="PDP-Desktop---POI-and-amenities"
                            transform="translate(-761.000000, -1527.000000)"
                            fill="#2979FF"
                            fill-rule="nonzero"
                          >
                            <g id="Group-28" transform="translate(503.000000, 1315.000000)">
                              <g id="Bitmap" transform="translate(0.000000, 75.000000)">
                                <g id="Group-7" transform="translate(84.000000, 67.000000)">
                                  <g id="Group-3" transform="translate(98.000000, 16.000000)">
                                    <g id="location-pin-with-price-copy-25">
                                      <path
                                        d="M82.2806042,71.6368316 C76.9832813,64.2315561 76,63.4715485 76,60.7499984 C76,57.0220657 79.1339948,54 83,54 C86.8660052,54 90,57.0220657 90,60.7499984 C90,63.4715485 89.0167187,64.2315561 83.7193958,71.6368316 C83.3717656,72.1210737 82.6281979,72.1210385 82.2806042,71.6368316 Z M83,64 C84.6568625,64 86,62.6568625 86,61 C86,59.3431375 84.6568625,58 83,58 C81.3431375,58 80,59.3431375 80,61 C80,62.6568625 81.3431375,64 83,64 Z"
                                        id="Shape-Copy-8"
                                      />
                                    </g>
                                  </g>
                                </g>
                              </g>
                            </g>
                          </g>
                        </g>
                      </svg>
                    </span>
                    مشاهده مکان هتل روی نقشه
                  </a>
                </div>
              </div>
            </div>
          </div>
          <div class="col-md-9 col-xs-12" data-v-21eb7522>
            <div class="row" data-v-21eb7522>
              <div class="hotel-detail-gallery px-md-0" data-v-21eb7522>
                <section
                  class="hotels-detail-container hidden-sm hidden-xs"
                  data-v-638cc802
                  data-v-21eb7522
                >
                  <div
                    class="background background--bottom-text"
                    style="background-image:url(https://cdn.alibaba.ir/inh/images/hotel/4460/01c73e53.jpg) ;"
                    data-v-638cc802
                  >
                    <div class="py-3 px-3" data-v-638cc802>
                      <div class="next-prev-arrow pull-left" data-v-638cc802>
                        <i class="icon-arrow-left"></i>
                        <i class="icon-arrow-right"></i>
                      </div>
                      <!---->
                    </div>
                  </div>
                  <div class="gallery-thumbnail" data-v-638cc802>
                    <div data-v-638cc802>
                      <div class="hv-image img-rounded hovered show-gallery" data-v-638cc802>
                        <div data-v-638cc802>
                          <span class="inline-block v-middle" data-v-638cc802>
                            <span class="svg-icon" data-v-638cc802>
                              <svg
                                viewBox="0 0 25 19"
                                version="1.1"
                                xmlns="http://www.w3.org/2000/svg"
                                xmlns:xlink="http://www.w3.org/1999/xlink"
                                fill="#424242"
                                width="25px"
                                height="19px"
                                class="svg-icon"
                                data-v-638cc802
                              >
                                <g stroke="none" stroke-width="1" fill="none" fill-rule="evenodd">
                                  <g
                                    id="Tour-Detail-[Select-Amount-Room]---Desktop"
                                    transform="translate(-1375.000000, -1539.000000)"
                                    fill="#424242"
                                    fill-rule="nonzero"
                                  >
                                    <g
                                      id="Group-13"
                                      transform="translate(607.000000, 1532.000000)"
                                    >
                                      <path
                                        d="M769.666667,7 C768.752959,7 768,7.75738661 768,8.67646862 L768,24.3235314 C768,25.2425994 768.752959,26 769.666667,26 L791.333333,26 C792.247042,26 793,25.2425994 793,24.3235314 L793,8.67646862 C793,7.75738661 792.247042,7 791.333333,7 L769.666667,7 Z M769.666667,8.11764574 L791.333333,8.11764574 C791.650706,8.11764574 791.888889,8.35722987 791.888889,8.67646862 L791.888889,20.3680993 L787.236111,16.6222537 C787.052227,16.4740259 786.771313,16.4628774 786.576388,16.595989 L782.470486,19.4337474 L776.958333,14.9457068 C776.843235,14.8511121 776.689275,14.8059424 776.541666,14.8234643 C776.454623,14.8355349 776.370554,14.8687653 776.298611,14.919512 L769.111111,19.9052542 L769.111111,8.67638479 C769.111111,8.35714605 769.349296,8.11756192 769.666667,8.11756192 L769.666667,8.11764574 Z M782.444444,10.911788 C781.223724,10.911788 780.222222,11.9191808 780.222222,13.1470795 C780.222222,14.3749782 781.223724,15.382371 782.444444,15.382371 C783.665164,15.382371 784.666666,14.3749782 784.666666,13.1470795 C784.666666,11.9191808 783.665164,10.911788 782.444444,10.911788 Z M782.444444,12.0294338 C783.064675,12.0294338 783.555555,12.5232013 783.555555,13.1470795 C783.555555,13.7709578 783.064675,14.2647253 782.444444,14.2647253 C781.824213,14.2647253 781.333333,13.7709578 781.333333,13.1470795 C781.333333,12.5232013 781.824213,12.0294338 782.444444,12.0294338 Z M776.585069,16.0721764 L782.097222,20.5601946 C782.281105,20.7084503 782.562019,20.7195989 782.756944,20.5864593 L786.854166,17.7486171 L791.888889,21.8000829 L791.888889,24.3235034 C791.888889,24.6427589 791.650706,24.8823263 791.333333,24.8823263 L769.666667,24.8823263 C769.349296,24.8823263 769.111111,24.6427589 769.111111,24.3235034 L769.111111,21.2587232 L776.585069,16.0721484 L776.585069,16.0721764 Z"
                                        id="Shape"
                                      />
                                    </g>
                                  </g>
                                </g>
                              </svg>
                            </span>
                            <span class="block my-1 hidden-xs" data-v-638cc802>گالری تصاویر</span>
                          </span>
                        </div>
                      </div>
                    </div>
                    <div data-v-638cc802>
                      <div
                      v-for="p in hotel.pic" :key="p.id"
                        class="hv-image img-rounded"
                        v-bind:style="{ backgroundImage: 'url(' + p.url + ')' }"
                        data-v-638cc802
                      >
                        <div data-v-638cc802>
                          <span class="inline-block v-middle" data-v-638cc802>
                            <span class="svg-icon block" data-v-638cc802>
                              <svg
                                viewBox="0 0 22 13"
                                version="1.1"
                                xmlns="http://www.w3.org/2000/svg"
                                xmlns:xlink="http://www.w3.org/1999/xlink"
                                fill
                                width="22px"
                                height="13px"
                                class="svg-icon"
                                data-v-638cc802
                              >
                                <g stroke="none" stroke-width="1" fill="none" fill-rule="evenodd">
                                  <g
                                    id="Tour-Detail-[if-select-2room]---Desktop"
                                    transform="translate(-1095.000000, -1777.000000)"
                                    fill="currentColor"
                                    fill-rule="nonzero"
                                  >
                                    <g
                                      id="Group-13"
                                      transform="translate(607.000000, 1532.000000)"
                                    >
                                      <path
                                        d="M498.9944,245 C493.937949,245.003931 489.443175,247.501581 488.033392,251.313119 C487.988869,251.433399 487.988869,251.566591 488.033392,251.686871 C489.444349,255.501583 493.944973,257.999754 499.005624,258 C504.062076,257.996069 508.556825,255.498419 509.966608,251.686871 C510.011131,251.566591 510.011131,251.433399 509.966608,251.313119 C508.55565,247.498417 504.055052,245.000246 498.9944,245 Z M499.000164,247.080003 C501.338501,247.080003 503.250187,249.068135 503.250187,251.499995 C503.250187,253.931855 501.338501,255.919997 499.000164,255.919997 C496.661827,255.919997 494.750142,253.931855 494.750142,251.499995 C494.750142,249.068135 496.661827,247.080003 499.000164,247.080003 Z M499.000164,248.640002 C497.472481,248.640002 496.25015,249.911223 496.25015,251.499995 C496.25015,253.088767 497.472481,254.359998 499.000164,254.359998 C500.527847,254.359998 501.750179,253.088767 501.750179,251.499995 C501.750179,249.911223 500.527847,248.640002 499.000164,248.640002 Z"
                                        id="Shape"
                                      />
                                    </g>
                                  </g>
                                </g>
                              </svg>
                            </span>
                            <span class="block hidden-xs" data-v-638cc802>مشاهده</span>
                          </span>
                        </div>
                      </div>
                    </div>
                  </div>
                  <!---->
                </section>
              </div>
              <div class="hotel-meta" data-v-21eb7522>
                <div class="hidden-md hidden-lg hotel-detail-title text-left" data-v-21eb7522>
                  <div class="hotel-detail-title" data-v-21eb7522>
                    <h2
                      class="hotel-detail-title-name m-0 inline-block ml-2 font-en ltr"
                    >Akgün Istanbul</h2>
                    <div class="rate-stars inline-block" data-v-02a24b22>
                      <i class="icon-star-rate active" data-v-02a24b22></i>
                      <i class="icon-star-rate active" data-v-02a24b22></i>
                      <i class="icon-star-rate active" data-v-02a24b22></i>
                      <i class="icon-star-rate active" data-v-02a24b22></i>
                      <i class="icon-star-rate active" data-v-02a24b22></i>
                    </div>
                    <div>
                      <div class="inline-block">
                        <a
                          href="#poi-section"
                          class="text-dark font-en"
                        >Adnan Menderes Bulv., Istanbul, Turkey</a>
                        <a href="#poi-section" class="btn btn-link text-blue">
                          <span class="hotel-detail-pin">
                            <svg
                              xmlns:xlink="http://www.w3.org/1999/xlink"
                              height="18px"
                              width="14px"
                              fill
                              xmlns="http://www.w3.org/2000/svg"
                              version="1.1"
                              viewBox="0 0 14 18"
                              class="svg-icon"
                            >
                              <g
                                id="point-of-interest"
                                stroke="none"
                                stroke-width="1"
                                fill="none"
                                fill-rule="evenodd"
                              >
                                <g
                                  id="PDP-Desktop---POI-and-amenities"
                                  transform="translate(-761.000000, -1527.000000)"
                                  fill="#2979FF"
                                  fill-rule="nonzero"
                                >
                                  <g id="Group-28" transform="translate(503.000000, 1315.000000)">
                                    <g id="Bitmap" transform="translate(0.000000, 75.000000)">
                                      <g id="Group-7" transform="translate(84.000000, 67.000000)">
                                        <g
                                          id="Group-3"
                                          transform="translate(98.000000, 16.000000)"
                                        >
                                          <g id="location-pin-with-price-copy-25">
                                            <path
                                              d="M82.2806042,71.6368316 C76.9832813,64.2315561 76,63.4715485 76,60.7499984 C76,57.0220657 79.1339948,54 83,54 C86.8660052,54 90,57.0220657 90,60.7499984 C90,63.4715485 89.0167187,64.2315561 83.7193958,71.6368316 C83.3717656,72.1210737 82.6281979,72.1210385 82.2806042,71.6368316 Z M83,64 C84.6568625,64 86,62.6568625 86,61 C86,59.3431375 84.6568625,58 83,58 C81.3431375,58 80,59.3431375 80,61 C80,62.6568625 81.3431375,64 83,64 Z"
                                              id="Shape-Copy-8"
                                            />
                                          </g>
                                        </g>
                                      </g>
                                    </g>
                                  </g>
                                </g>
                              </g>
                            </svg>
                          </span>
                          مشاهده مکان هتل روی نقشه
                        </a>
                      </div>
                    </div>
                  </div>
                </div>
                <!---->
              </div>
              <div
                class="navbar pb-3 px-1 mt-4 hidden-xs hidden-sm hotel-detail-sticky"
                style="top: 0px;"
                data-v-7532cfc4
                data-v-21eb7522
              >
                <nav data-v-7532cfc4>
                  <ul
                    class="navbar__list list-unstyled list-inline col-md-9 p-0 flex flex-justify-space-between"
                    data-v-7532cfc4
                  >
                    <li data-v-7532cfc4>
                      <a href="#room-section" data-v-7532cfc4 class>اتاق های موجود</a>
                    </li>
                    <li data-v-7532cfc4>
                      <a href="#poi-section" data-v-7532cfc4 class>موقعیت مکانی</a>
                    </li>
                    <li data-v-7532cfc4>
                      <a href="#facility-section" data-v-7532cfc4 class>امکانات هتل</a>
                    </li>
                    <li class="hidden" data-v-7532cfc4>
                      <a
                        href="#mandatory-fee-section"
                        style="display:none;"
                        data-v-7532cfc4
                      >هزینه&zwnj;های جانبی</a>
                    </li>
                  </ul>
                </nav>
              </div>
              <div id="room-section" class="scroll-spy-item" data-v-21eb7522>
                <div class="hotel-detail-content-title" data-v-21eb7522>
                  <svg
                    fill
                    width="16px"
                    height="16px"
                    viewBox="0 0 16 16"
                    version="1.1"
                    xmlns="http://www.w3.org/2000/svg"
                    xmlns:xlink="http://www.w3.org/1999/xlink"
                    class="svg-icon"
                    data-v-21eb7522
                  >
                    <defs>
                      <path
                        d="M1.99998791,10.6666667 L13.9999154,10.6666667 L13.9999154,8 C13.9999154,7.26362033 13.4029653,6.66666667 12.6665901,6.66666667 L3.33331318,6.66666667 C2.59693797,6.66666667 1.99998791,7.26362033 1.99998791,8 L1.99998791,10.6666667 Z M7.99995164,6 L12.6665901,6 C13.7711529,6 14.666578,6.8954305 14.666578,8 L14.666578,11.3333333 L1.33332527,11.3333333 L1.33332527,8 C1.33332527,6.8954305 2.22875036,6 3.33331318,6 L7.99995164,6 Z M6.66662637,10.6666667 L6.66662637,10 C6.66662637,9.63181017 6.36815134,9.33333333 5.99996373,9.33333333 L4.66663846,9.33333333 C4.29845085,9.33333333 3.99997582,9.63181017 3.99997582,10 L3.99997582,10.6666667 L6.66662637,10.6666667 Z M4.66663846,8.66666667 L5.99996373,8.66666667 C6.73633895,8.66666667 7.333289,9.26362033 7.333289,10 L7.333289,11.3333333 L3.33331318,11.3333333 L3.33331318,10 C3.33331318,9.26362033 3.93026324,8.66666667 4.66663846,8.66666667 Z M11.9999275,10.6666667 L11.9999275,10 C11.9999275,9.63181017 11.7014524,9.33333333 11.3332648,9.33333333 L9.99993955,9.33333333 C9.63175194,9.33333333 9.33327691,9.63181017 9.33327691,10 L9.33327691,10.6666667 L11.9999275,10.6666667 Z M9.99993955,8.66666667 L11.3332648,8.66666667 C12.06964,8.66666667 12.6665901,9.26362033 12.6665901,10 L12.6665901,11.3333333 L8.66661428,11.3333333 L8.66661428,10 C8.66661428,9.26362033 9.26356434,8.66666667 9.99993955,8.66666667 Z M1.99998791,11.3333333 C1.2636127,11.3333333 0.666662637,11.930287 0.666662637,12.6666667 C0.666662637,13.4030463 1.2636127,14 1.99998791,14 L13.9999154,14 C14.7362906,14 15.3332406,13.4030463 15.3332406,12.6666667 C15.3332406,11.930287 14.7362906,11.3333333 13.9999154,11.3333333 L1.99998791,11.3333333 Z M2.66665055,14.6666667 L1.99998791,14.6666667 C0.895425087,14.6666667 1.35269933e-16,13.7712362 0,12.6666667 C-1.35269933e-16,11.5620972 0.895425087,10.6666667 1.99998791,10.6666667 L13.9999154,10.6666667 C15.1044782,10.6666667 15.9999033,11.5620972 15.9999033,12.6666667 C15.9999033,13.7712362 15.1044782,14.6666667 13.9999154,14.6666667 L13.3332527,14.6666667 L13.3332527,15.6666687 C13.3332527,15.8507625 13.1840152,16 12.9999214,16 C12.8158276,16 12.6665901,15.8507625 12.6665901,15.6666687 L12.6665901,14.6666667 L3.33331318,14.6666667 L3.33331318,15.6666687 C3.33331318,15.8507625 3.18407567,16 2.99998187,16 C2.81588806,16 2.66665055,15.8507625 2.66665055,15.6666687 L2.66665055,14.6666667 Z M5.18490415,4.34154953 C5.03172884,4.44366702 4.82477365,4.40227573 4.72265678,4.2490995 C4.62053991,4.09592327 4.66193095,3.88896682 4.81510625,3.78684934 L7.07549233,2.27991618 C7.63532129,1.90669461 8.36465283,1.90669461 8.9244818,2.27991618 L11.1848679,3.78684934 C11.3380432,3.88896682 11.3794342,4.09592327 11.2773174,4.2490995 C11.1752005,4.40227573 10.9682453,4.44366702 10.81507,4.34154953 L8.55468391,2.83461637 C8.21878653,2.61068343 7.7811876,2.61068343 7.44529022,2.83461637 L5.18490415,4.34154953 Z M0.506694279,4.94335685 C0.349441618,5.03907644 0.144367559,4.98919326 0.0486485475,4.83193965 C-0.0470704638,4.67468603 0.00281241558,4.46961073 0.160065077,4.37389115 L6.78679779,0.34020337 C7.53200067,-0.113401123 8.46799933,-0.113401123 9.21320221,0.34020337 L15.8399349,4.37389115 C15.9971876,4.46961073 16.0470705,4.67468603 15.9513515,4.83193965 C15.8556324,4.98919326 15.6505584,5.03907644 15.4933057,4.94335685 L8.86657301,0.909669074 C8.33428524,0.585665864 7.66571476,0.585665864 7.13342699,0.909669074 L0.506694279,4.94335685 Z"
                        id="path-1"
                      />
                    </defs>
                    <g stroke="none" stroke-width="1" fill="none" fill-rule="evenodd">
                      <g
                        id="International-Hotel---PDP---cancel-rules-expanded--Desktop"
                        transform="translate(-451.000000, -330.000000)"
                      >
                        <g id="Group-12" transform="translate(200.000000, 236.000000)">
                          <g id="Group-13" transform="translate(20.000000, 17.000000)">
                            <g
                              id="Icon-/-Hotel-&amp;-Facilities-/-bed"
                              transform="translate(231.000000, 77.000000)"
                            >
                              <mask id="mask-2-bed" fill="white">
                                <use xlink:href="#path-1" />
                              </mask>
                              <use
                                id="bed"
                                fill="currentColor"
                                fill-rule="nonzero"
                                xlink:href="#path-1"
                              />
                            </g>
                          </g>
                        </g>
                      </g>
                    </g>
                  </svg>
                  <h3 class="text-black inline-block" data-v-21eb7522>اتاق های قابل رزرو</h3>
                </div>
                <!---->
                <!---->
                <div data-v-fe9a6372 data-v-21eb7522>
   <div data-v-aa6edd58="" class="hotel-detail-room-list__item">
      <div data-v-712fe31c="" data-v-fb0c0032="" data-v-aa6edd58="" class="common-box">
         <div data-v-fb0c0032="" data-v-712fe31c="" class="hotel-rooms-card" v-for="r in hotel.room" :key="r.id">
            <div data-v-fb0c0032="" data-v-712fe31c="" class="hotel-rooms-card__rooms-info">
               <ul data-v-fb0c0032="" data-v-712fe31c="" class="hotel-rooms-card__room-list">
                  <li data-v-fb0c0032="" data-v-712fe31c="" class="hotel-rooms-card__room-list__item">
                     <div data-v-7df3f340="" data-v-fb0c0032="" class="hotel-single-room" data-v-712fe31c="">                        
                        <div data-v-7df3f340="" class="hotel-single-room__details">
                           <ul data-v-920a8654="" data-v-7df3f340="" class="room-details flex flex-wrap flex-row flex-justify-start flex-align-stretch">
                              <li data-v-920a8654="" class="room-details__item room-details__item--services"><span data-v-3224991c="" data-v-920a8654="" class="meal-plan-badge room-details__item--services__badge meal-plan-badge--BB">
                                 {{r.name}}
                                 </span> <span data-v-920a8654="" class="room-details__item--services__label">به همراه صبحانه: {{r.breakfast?"هست":"نیست"}}</span>
                              </li>
                              <li data-v-920a8654="" class="room-details__item">
                                 <svg data-v-920a8654="" width="27px" height="27px" viewBox="0 0 24 24" version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" aria-hidden="true" focusable="false" class="room-details__item__icon">
                                    <g data-v-920a8654="" fill="currentColor" fill-rule="nonzero">
                                       <path data-v-920a8654="" d="M12,10.5 C14.6233526,10.5 16.75,8.37335256 16.75,5.75 C16.75,3.12664744 14.6233526,1 12,1 C9.37664744,1 7.25,3.12664744 7.25,5.75 C7.25,8.37335256 9.37664744,10.5 12,10.5 Z M12,11.5 C8.82436269,11.5 6.25,8.92563731 6.25,5.75 C6.25,2.57436269 8.82436269,0 12,0 C15.1756373,0 17.75,2.57436269 17.75,5.75 C17.75,8.92563731 15.1756373,11.5 12,11.5 Z M22,24 C22,18.4771525 17.5228475,14 12,14 C6.4771525,14 2,18.4771525 2,24 L1,24 C1,17.9248678 5.92486775,13 12,13 C18.0751322,13 23,17.9248678 23,24 L22.5,24 L22,24 Z"></path>
                                    </g>
                                 </svg>
                                 <span data-v-920a8654="">{{r.adult}}} بزرگسال</span>
                                 <span data-v-920a8654="">{{r.kid}}} بزرگسال</span>
                              </li>
                              <div data-v-920a8654="" class="room-details__break"></div>
                              
                           </ul>
                        </div>
                     </div>
                  </li>
               </ul>
            </div>
            <div data-v-fb0c0032="" data-v-712fe31c="" class="hotel-rooms-card__price-info">

               <div data-v-fb0c0032="" data-v-712fe31c="" class="hotel-rooms-card__price-info__button flex flex-column flex-align-center">
                  <button data-v-0896e146="" data-v-fb0c0032="" type="button" class="basic-button basic-button--block basic-button--primary" data-v-712fe31c="">
                     <!----> 
                     رزرو این اتاق
                  </button>
               </div>
            </div>
         </div>
         <div data-v-fb0c0032="" data-v-712fe31c="" class="hotel-rooms-card__refund-policy">
            <!----> <!---->
         </div>
         <!---->
      </div>
   </div>
</div>
              </div>
              <div
                id="poi-section"
                class="point-of-interest clearfix px-md-0 scroll-spy-item"
                data-v-21eb7522
              >
                <h3 class="hotel-detail-content-title">
                  <svg
                    xmlns:xlink="http://www.w3.org/1999/xlink"
                    height="16px"
                    width="16px"
                    fill
                    xmlns="http://www.w3.org/2000/svg"
                    version="1.1"
                    viewBox="0 0 16 16"
                    class="svg-icon"
                  >
                    <defs />
                    <g stroke="none" stroke-width="1" fill="none" fill-rule="evenodd">
                      <g
                        transform="translate(-220.000000, -1182.000000)"
                        fill="currentColor"
                        fill-rule="nonzero"
                      >
                        <g transform="translate(200.000000, 1105.000000)">
                          <g transform="translate(20.000000, 77.000000)">
                            <g>
                              <g>
                                <path
                                  d="M13,6 C13,3.23857625 10.7614237,1 8,1 C5.23857625,1 3,3.23857625 3,6 C3,7.75445641 4.65668391,10.6328469 8,14.4887079 C11.3433161,10.6328469 13,7.75445641 13,6 Z M8,16 C4,11.5424723 2,8.209139 2,6 C2,2.6862915 4.6862915,0 8,0 C11.3137085,0 14,2.6862915 14,6 C14,8.209139 12,11.5424723 8,16 Z M8,9 C6.35090988,9 5,7.66130472 5,5.99990298 C5,4.338653 6.35095133,3 8,3 C9.64904867,3 11,4.338653 11,5.99990298 C11,7.66130472 9.64909012,9 8,9 Z M8,8 C9.10166665,8 10,7.10416857 10,5.99990298 C10,4.89580222 9.10163845,4 8,4 C6.89836155,4 6,4.89580222 6,5.99990298 C6,7.10416857 6.89833335,8 8,8 Z"
                                />
                              </g>
                            </g>
                          </g>
                        </g>
                      </g>
                    </g>
                  </svg>
                  موقعیت مکانی
                </h3>
                <div>
                  <!---->
                  <div class="col-xs-12 mt-3 px-0">
                    <div class="map vue2leaflet-map-ssr">
                      <iframe :src="hotel.location" width="100%" height="290" frameborder="0" style="border:0;" allowfullscreen="" aria-hidden="false" tabindex="0"></iframe>
                    </div>
                  </div>
                </div>
                <p
                  class="col-xs-12 mt-2 text-dark p-0"
                >فاصله&zwnj;ها بر اساس خط صاف در نقشه برآورد شده&zwnj;اند. فاصله واقعی ممکن است متفاوت باشد.</p>
              </div>
              <div
                id="facility-section"
                class="px-md-0 scroll-spy-item"
                data-v-1150f8fd
                data-v-21eb7522
              >
                <h3 class="hotel-detail-content-title" data-v-1150f8fd>
                  <svg
                    xmlns:xlink="http://www.w3.org/1999/xlink"
                    height="32px"
                    width="32px"
                    fill
                    xmlns="http://www.w3.org/2000/svg"
                    version="1.1"
                    viewBox="0 0 32 32"
                    class="svg-icon"
                    data-v-1150f8fd
                  >
                    <g id="Detail" stroke="none" stroke-width="1" fill="none" fill-rule="evenodd">
                      <g
                        id="PDP-Desktop---POI-and-amenities"
                        transform="translate(-1371.000000, -2673.000000)"
                        stroke="#242424"
                        stroke-width="2"
                      >
                        <g id="Group-3-Copy" transform="translate(1257.000000, 2674.000000)">
                          <path
                            d="M130,25.2638464 L121.631467,29.898864 C121.052464,30.2198653 120.359461,29.7308634 120.467462,29.0768609 L122.075468,19.1978232 L115.224941,12.1642964 C114.776439,11.7007946 115.03594,10.9222917 115.673443,10.8247913 L125.10098,9.38178578 L129.281497,0.456751742 C129.567998,-0.152250581 130.432002,-0.152250581 130.718503,0.456751742 L134.89902,9.38178578 L144.326557,10.8247913 C144.96406,10.9222917 145.223561,11.7007946 144.775059,12.1642964 L137.924532,19.1978232 L139.532538,29.0768609 C139.640539,29.7308634 138.947536,30.2198653 138.368533,29.898864 L130,25.2638464 Z"
                            id="star"
                          />
                        </g>
                      </g>
                    </g>
                  </svg>
                  امکانات هتل
                </h3>
                <div class="c-read-more" data-v-539448ea data-v-1150f8fd>
                  <div :class="this.open==true?'':'half-text'" style data-v-539448ea>
                    <div data-v-539448ea data-v-1150f8fd>
                      <div data-v-539448ea data-v-1150f8fd>
                        <svg
                          xmlns:xlink="http://www.w3.org/1999/xlink"
                          height="36px"
                          width="36px"
                          fill
                          xmlns="http://www.w3.org/2000/svg"
                          version="1.1"
                          viewBox="0 0 24 24"
                          class="svg-icon"
                          data-v-539448ea
                          data-v-1150f8fd
                        >
                          <g
                            id="General"
                            stroke="none"
                            stroke-width="1"
                            fill="none"
                            fill-rule="evenodd"
                          >
                            <path
                              d="M12,1.5 C17.7989899,1.5 22.5,6.20101013 22.5,12 C22.5,17.7989899 17.7989899,22.5 12,22.5 C6.20101013,22.5 1.5,17.7989899 1.5,12 C1.5,6.20101013 6.20101013,1.5 12,1.5 Z M12,2.5 C6.75329488,2.5 2.5,6.75329488 2.5,12 C2.5,17.2467051 6.75329488,21.5 12,21.5 C17.2467051,21.5 21.5,17.2467051 21.5,12 C21.5,6.75329488 17.2467051,2.5 12,2.5 Z M12,17 C12.2454599,17 12.4496084,17.1768752 12.4919443,17.4101244 L12.5,17.5 L12.5,18 C12.5,18.2761424 12.2761424,18.5 12,18.5 C11.7545401,18.5 11.5503916,18.3231248 11.5080557,18.0898756 L11.5,18 L11.5,17.5 C11.5,17.2238576 11.7238576,17 12,17 Z M12,5.5 C12.2454599,5.5 12.4496084,5.67687516 12.4919443,5.91012437 L12.5,6 L12.5,15 C12.5,15.2761424 12.2761424,15.5 12,15.5 C11.7545401,15.5 11.5503916,15.3231248 11.5080557,15.0898756 L11.5,15 L11.5,6 C11.5,5.72385763 11.7238576,5.5 12,5.5 Z"
                              id="Combined-Shape"
                              fill="#757575"
                              fill-rule="nonzero"
                            />
                          </g>
                        </svg>
                        <div
                          class="inline-block hotel-facilities mb-4 pr-3"
                          data-v-539448ea
                          data-v-1150f8fd
                        >
                          <p class="mb-0 notice text-darker" data-v-539448ea data-v-1150f8fd>کلی</p>
                          <ul class="list-inline" data-v-539448ea data-v-1150f8fd>
                            <li class="ml-5" data-v-539448ea data-v-1150f8fd v-for="f in hotel.feature" :key="f.id">{{f.name}}: {{f.value}}</li>
                          </ul>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="read-more-wrapper" data-v-539448ea>
                    <a
                      id="#description-section"
                      class="read-more-button"
                      data-v-539448ea
                      v-if="this.open == false"
                      @click="opendiv(true)"
                    >
                      مشاهده همه امکانات
                      <i class="icon-arrow-down-16" data-v-539448ea></i>
                    </a>
                    <a
                      id="#description-section"
                      class="read-more-button"
                      data-v-539448ea
                      @click="opendiv(false)"
                      v-else
                    >
                      کمتر
                      <i class="icon-arrow-up-16" data-v-539448ea></i>
                    </a>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div
            id="sticky-search-box"
            class="hidden-xs hidden-sm col-xs-3 hotel-detail-sticky"
            style="top: 25px;"
            data-v-21eb7522
          >
            <div slot="sidebar" class="c-search-room box row" data-v-fc995ab2 data-v-21eb7522>
              <div class="search-items-wrapper" data-v-fc995ab2>
                <div
                  class="col-xs-7 col-sm-5 col-md-5 pr-0 search-item-container search-datepicker"
                  data-v-fc995ab2
                >
                  <div
                    data-test="alibabaDatepicker"
                    class="alibaba-datepicker"
                    data-v-65b601f8
                    data-v-fc995ab2
                  >
                    <div class="col-xs-6 search-item" data-v-65b601f8 data-v-fc995ab2>
                      <div class="search-item-input" data-v-65b601f8 data-v-fc995ab2>
                        <div class="xs" data-v-65b601f8 data-v-fc995ab2>
                          <div data-dropdown-prevent class="row" data-v-65b601f8 data-v-fc995ab2>
                            <div class="col-xs-10 pl-0" data-v-65b601f8 data-v-fc995ab2>
                              <span
                                class="text-gray text-nowrap mb-1 block"
                                data-v-65b601f8
                                data-v-fc995ab2
                              >تاریخ ورود</span>
                              <div
                                data-test="departingDatePicker"
                                class="input-group"
                                data-v-65b601f8
                                data-v-fc995ab2
                              >
                                <input
                                  placeholder="انتخاب کنید"
                                  tabindex="2"
                                  readonly="readonly"
                                  class="form-control p-0 search-item-height"
                                  data-v-65b601f8
                                  data-v-fc995ab2
                                />
                                <span class="search-item-arrow" data-v-65b601f8 data-v-fc995ab2>
                                  <svg
                                    fill="currentCollor"
                                    width="17px"
                                    height="9px"
                                    viewBox="0 0 17 9"
                                    version="1.1"
                                    xmlns="http://www.w3.org/2000/svg"
                                    xmlns:xlink="http://www.w3.org/1999/xlink"
                                    data-v-65b601f8
                                    data-v-fc995ab2
                                    class
                                  >
                                    <g
                                      stroke="none"
                                      stroke-width="1"
                                      fill="none"
                                      fill-rule="evenodd"
                                    >
                                      <g
                                        id="International-Hotel---PDP---Desktop"
                                        transform="translate(-1186.000000, -2842.000000)"
                                        fill="#2D8AFF"
                                        fill-rule="nonzero"
                                      >
                                        <g
                                          id="Group-22"
                                          transform="translate(195.000000, 2713.000000)"
                                        >
                                          <g
                                            id="search-hotel"
                                            transform="translate(5.000000, 66.000000)"
                                          >
                                            <g
                                              id="Group-17"
                                              transform="translate(514.000000, 27.000000)"
                                            >
                                              <g id="Group-35">
                                                <path
                                                  d="M488.587927,36.3977476 L488.587927,36.3977476 C488.807597,36.6097808 488.813788,36.9597454 488.601754,37.1794153 C488.597227,37.1841056 488.592617,37.1887155 488.587927,37.1932427 L480.5,45 L472.412073,37.1932427 C472.192403,36.9812094 472.186212,36.6312448 472.398246,36.4115749 C472.402773,36.4068846 472.407383,36.4022748 472.412073,36.3977476 L472.412073,36.3977476 C472.641975,36.1758381 473.006317,36.1758381 473.236219,36.3977476 L480.5,43.4090097 L487.763781,36.3977476 C487.993683,36.1758381 488.358025,36.1758381 488.587927,36.3977476 Z"
                                                  id="Rectangle-2-Copy"
                                                  transform="translate(480.500000, 40.500000) rotate(-360.000000) translate(-480.500000, -40.500000) "
                                                />
                                              </g>
                                            </g>
                                          </g>
                                        </g>
                                      </g>
                                    </g>
                                  </svg>
                                </span>
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="col-xs-6 search-item" data-v-65b601f8 data-v-fc995ab2>
                      <div class="search-item-input" data-v-65b601f8 data-v-fc995ab2>
                        <div class="xs" data-v-65b601f8 data-v-fc995ab2>
                          <div data-dropdown-prevent class="row" data-v-65b601f8 data-v-fc995ab2>
                            <div class="col-xs-10 pl-0" data-v-65b601f8 data-v-fc995ab2>
                              <span
                                class="text-gray text-nowrap mb-1 block"
                                data-v-65b601f8
                                data-v-fc995ab2
                              >تاریخ خروج</span>
                              <div
                                data-test="returningDatePicker"
                                class="input-group"
                                data-v-65b601f8
                                data-v-fc995ab2
                              >
                                <input
                                  placeholder="انتخاب کنید"
                                  tabindex="3"
                                  readonly="readonly"
                                  class="form-control p-0"
                                  data-v-65b601f8
                                  data-v-fc995ab2
                                />
                                <span class="search-item-arrow" data-v-65b601f8 data-v-fc995ab2>
                                  <svg
                                    fill="currentCollor"
                                    width="17px"
                                    height="9px"
                                    viewBox="0 0 17 9"
                                    version="1.1"
                                    xmlns="http://www.w3.org/2000/svg"
                                    xmlns:xlink="http://www.w3.org/1999/xlink"
                                    data-v-65b601f8
                                    data-v-fc995ab2
                                    class
                                  >
                                    <g
                                      stroke="none"
                                      stroke-width="1"
                                      fill="none"
                                      fill-rule="evenodd"
                                    >
                                      <g
                                        id="International-Hotel---PDP---Desktop"
                                        transform="translate(-1186.000000, -2842.000000)"
                                        fill="#2D8AFF"
                                        fill-rule="nonzero"
                                      >
                                        <g
                                          id="Group-22"
                                          transform="translate(195.000000, 2713.000000)"
                                        >
                                          <g
                                            id="search-hotel"
                                            transform="translate(5.000000, 66.000000)"
                                          >
                                            <g
                                              id="Group-17"
                                              transform="translate(514.000000, 27.000000)"
                                            >
                                              <g id="Group-35">
                                                <path
                                                  d="M488.587927,36.3977476 L488.587927,36.3977476 C488.807597,36.6097808 488.813788,36.9597454 488.601754,37.1794153 C488.597227,37.1841056 488.592617,37.1887155 488.587927,37.1932427 L480.5,45 L472.412073,37.1932427 C472.192403,36.9812094 472.186212,36.6312448 472.398246,36.4115749 C472.402773,36.4068846 472.407383,36.4022748 472.412073,36.3977476 L472.412073,36.3977476 C472.641975,36.1758381 473.006317,36.1758381 473.236219,36.3977476 L480.5,43.4090097 L487.763781,36.3977476 C487.993683,36.1758381 488.358025,36.1758381 488.587927,36.3977476 Z"
                                                  id="Rectangle-2-Copy"
                                                  transform="translate(480.500000, 40.500000) rotate(-360.000000) translate(-480.500000, -40.500000) "
                                                />
                                              </g>
                                            </g>
                                          </g>
                                        </g>
                                      </g>
                                    </g>
                                  </svg>
                                </span>
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="clearfix" data-v-65b601f8></div>
                    <!---->
                    <div class="alibaba-datepicker__wrapper v-dropdown fade left" data-v-65b601f8>
                      <!---->
                      <div class="flex-1 relative" data-v-65b601f8>
                        <header class="alibaba-datepicker__header rtl" data-v-65b601f8>
                          <div data-v-65b601f8>
                            <button
                              data-test="datepickerChangeMode"
                              type="button"
                              class="btn btn-raw active"
                              data-v-65b601f8
                            >
                              <span class="pull-right" data-v-65b601f8>تغییر به میلادی</span>
                            </button>
                            <span
                              data-test="datepickerMode"
                              class="w-normal px-2 text-center"
                              data-v-65b601f8
                            >تقویم شمسی</span>
                            <span data-v-65b601f8>
                              <button
                                data-test="datepickerGoToday"
                                type="button"
                                class="btn btn-raw btn-today hidden-xs pull-left"
                                data-v-65b601f8
                              >برو به امروز</button>
                              <button
                                data-test="datepickerClose"
                                type="button"
                                class="close visible-xs"
                                data-v-65b601f8
                              >
                                <span class="svg-icon" data-v-65b601f8>
                                  <svg
                                    width="17px"
                                    height="17px"
                                    viewBox="0 0 17 17"
                                    version="1.1"
                                    xmlns="http://www.w3.org/2000/svg"
                                    xmlns:xlink="http://www.w3.org/1999/xlink"
                                    data-v-65b601f8
                                    class
                                  >
                                    <g
                                      stroke="none"
                                      stroke-width="1"
                                      fill="none"
                                      fill-rule="evenodd"
                                    >
                                      <g transform="translate(-25.000000, -18.000000)">
                                        <g transform="translate(0.000000, 1.000000)">
                                          <g transform="translate(0.000000, 15.000000)">
                                            <g transform="translate(25.000000, 2.000000)">
                                              <rect
                                                x="0"
                                                y="0"
                                                width="16.6666667"
                                                height="16.6666667"
                                              />
                                              <path
                                                d="M9.0699029,8.33333333 L16.5141181,15.7775486 C16.7175162,15.9809466 16.7175162,16.31072 16.5141181,16.5141181 C16.31072,16.7175162 15.9809466,16.7175162 15.7775486,16.5141181 L8.33333333,9.0699029 L0.889118115,16.5141181 C0.685720047,16.7175162 0.35594662,16.7175162 0.152548551,16.5141181 C-0.0508495172,16.31072 -0.0508495172,15.9809466 0.152548551,15.7775486 L7.59676377,8.33333333 L0.152548551,0.889118115 C-0.0508495172,0.685720047 -0.0508495172,0.35594662 0.152548551,0.152548551 C0.35594662,-0.0508495172 0.685720047,-0.0508495172 0.889118115,0.152548551 L8.33333333,7.59676377 L15.7775486,0.152548551 C15.9809466,-0.0508495172 16.31072,-0.0508495172 16.5141181,0.152548551 C16.7175162,0.35594662 16.7175162,0.685720047 16.5141181,0.889118115 L9.0699029,8.33333333 Z"
                                                fill="#9E9E9E"
                                                fill-rule="nonzero"
                                              />
                                            </g>
                                          </g>
                                        </g>
                                      </g>
                                    </g>
                                  </svg>
                                </span>
                              </button>
                            </span>
                          </div>
                          <!---->
                        </header>
                        <!---->
                        <div class="alibaba-datepicker__arrows hidden-xs" data-v-65b601f8>
                          <button
                            type="button"
                            disabled="disabled"
                            data-test="datepickerPreviousMonth"
                            class="btn"
                            data-v-65b601f8
                          >
                            <svg
                              width="10px"
                              height="9px"
                              fill="currentColor"
                              viewBox="0 0 10 9"
                              version="1.1"
                              xmlns="http://www.w3.org/2000/svg"
                              xmlns:xlink="http://www.w3.org/1999/xlink"
                              class="block"
                              data-v-65b601f8
                            >
                              <g stroke="none" stroke-width="1" fill-rule="evenodd">
                                <g
                                  transform="translate(-891.000000, -614.000000)"
                                  fill-rule="nonzero"
                                >
                                  <g transform="translate(376.000000, 547.000000)">
                                    <g transform="translate(510.000000, 62.000000)">
                                      <path
                                        d="M11.6604348,5.23588598 L14.8336263,9.06309507 L14.7652174,8.99686061 C14.7962499,9.02278001 14.8242801,9.05097896 14.8492665,9.08101169 L14.8720021,9.11029229 L14.8720021,9.11029229 L14.885,9.13 L14.8924536,9.13923358 C14.8996065,9.15009347 14.9064091,9.16113092 14.9128598,9.17232874 L14.9176246,9.18193403 L14.9176246,9.18193403 C14.9253373,9.19534632 14.9324305,9.20907617 14.9389856,9.22308616 C14.944727,9.23497938 14.94989,9.24703455 14.9546797,9.25921274 L14.9497106,9.24737076 C14.9537629,9.25811158 14.958005,9.2691225 14.9619366,9.28021093 C14.9694339,9.30014871 14.975549,9.32045932 14.9806836,9.34116098 C14.9832691,9.35330177 14.9859583,9.36565399 14.988286,9.3780534 C14.9921992,9.39665421 14.9949129,9.4156006 14.9968024,9.43479169 C14.9976374,9.44744792 14.998502,9.45985136 14.9990161,9.47226028 L14.9998017,9.48595501 L14.9998017,9.48595501 L15,9.50009883 L14.9999909,9.52178254 C14.9995878,9.53419019 14.9988339,9.54659438 14.9977276,9.55897904 L15,9.50009883 C15,9.54607857 14.9952888,9.5909447 14.9863242,9.63423773 L14.9851635,9.64085801 C14.9832844,9.64602709 14.9804434,9.6580185 14.9772653,9.66993056 C14.9714389,9.69412895 14.9636141,9.71786664 14.9545197,9.74095911 C14.9514858,9.74713603 14.9489078,9.75340808 14.9462302,9.75964438 C14.9366357,9.78332785 14.9251226,9.80623728 14.9123599,9.82832685 L14.8985385,9.85030904 L14.8985385,9.85030904 L14.8727875,9.88848956 C14.8652421,9.89870988 14.8573568,9.90877275 14.8491304,9.91866384 L11.6608696,13.7643117 C11.5321739,13.9196914 11.3465217,14 11.1591304,14 C11.0121739,14 10.8643478,13.9502436 10.7426087,13.8485484 C10.4656522,13.6172247 10.4278261,13.2043337 10.6586957,12.9267452 L12.956,10.154 L5.65217391,10.1547886 C5.29173913,10.1547886 5,9.86192405 5,9.50009883 C5,9.1382736 5.29173913,8.84540904 5.65217391,8.84540904 L12.956,8.845 L10.6582609,6.07345246 C10.4278261,5.79542752 10.4656522,5.3825365 10.7421739,5.15164923 C11.0191304,4.91988904 11.4304348,4.95829751 11.6604348,5.23588598 Z M14.8897045,9.13509429 L14.885,9.13 L14.8717517,9.10962825 C14.8779571,9.11799734 14.8839416,9.12648891 14.8897045,9.13509429 Z"
                                      />
                                    </g>
                                  </g>
                                </g>
                              </g>
                            </svg>
                          </button>
                          <button
                            type="button"
                            data-test="datepickerNextMonth"
                            class="btn"
                            data-v-65b601f8
                          >
                            <svg
                              width="10px"
                              height="9px"
                              fill="currentColor"
                              viewBox="0 0 10 9"
                              version="1.1"
                              xmlns="http://www.w3.org/2000/svg"
                              xmlns:xlink="http://www.w3.org/1999/xlink"
                              class="mirror-x block"
                              data-v-65b601f8
                            >
                              <g stroke="none" stroke-width="1" fill-rule="evenodd">
                                <g
                                  transform="translate(-891.000000, -614.000000)"
                                  fill-rule="nonzero"
                                >
                                  <g transform="translate(376.000000, 547.000000)">
                                    <g transform="translate(510.000000, 62.000000)">
                                      <path
                                        d="M11.6604348,5.23588598 L14.8336263,9.06309507 L14.7652174,8.99686061 C14.7962499,9.02278001 14.8242801,9.05097896 14.8492665,9.08101169 L14.8720021,9.11029229 L14.8720021,9.11029229 L14.885,9.13 L14.8924536,9.13923358 C14.8996065,9.15009347 14.9064091,9.16113092 14.9128598,9.17232874 L14.9176246,9.18193403 L14.9176246,9.18193403 C14.9253373,9.19534632 14.9324305,9.20907617 14.9389856,9.22308616 C14.944727,9.23497938 14.94989,9.24703455 14.9546797,9.25921274 L14.9497106,9.24737076 C14.9537629,9.25811158 14.958005,9.2691225 14.9619366,9.28021093 C14.9694339,9.30014871 14.975549,9.32045932 14.9806836,9.34116098 C14.9832691,9.35330177 14.9859583,9.36565399 14.988286,9.3780534 C14.9921992,9.39665421 14.9949129,9.4156006 14.9968024,9.43479169 C14.9976374,9.44744792 14.998502,9.45985136 14.9990161,9.47226028 L14.9998017,9.48595501 L14.9998017,9.48595501 L15,9.50009883 L14.9999909,9.52178254 C14.9995878,9.53419019 14.9988339,9.54659438 14.9977276,9.55897904 L15,9.50009883 C15,9.54607857 14.9952888,9.5909447 14.9863242,9.63423773 L14.9851635,9.64085801 C14.9832844,9.64602709 14.9804434,9.6580185 14.9772653,9.66993056 C14.9714389,9.69412895 14.9636141,9.71786664 14.9545197,9.74095911 C14.9514858,9.74713603 14.9489078,9.75340808 14.9462302,9.75964438 C14.9366357,9.78332785 14.9251226,9.80623728 14.9123599,9.82832685 L14.8985385,9.85030904 L14.8985385,9.85030904 L14.8727875,9.88848956 C14.8652421,9.89870988 14.8573568,9.90877275 14.8491304,9.91866384 L11.6608696,13.7643117 C11.5321739,13.9196914 11.3465217,14 11.1591304,14 C11.0121739,14 10.8643478,13.9502436 10.7426087,13.8485484 C10.4656522,13.6172247 10.4278261,13.2043337 10.6586957,12.9267452 L12.956,10.154 L5.65217391,10.1547886 C5.29173913,10.1547886 5,9.86192405 5,9.50009883 C5,9.1382736 5.29173913,8.84540904 5.65217391,8.84540904 L12.956,8.845 L10.6582609,6.07345246 C10.4278261,5.79542752 10.4656522,5.3825365 10.7421739,5.15164923 C11.0191304,4.91988904 11.4304348,4.95829751 11.6604348,5.23588598 Z M14.8897045,9.13509429 L14.885,9.13 L14.8717517,9.10962825 C14.8779571,9.11799734 14.8839416,9.12648891 14.8897045,9.13509429 Z"
                                      />
                                    </g>
                                  </g>
                                </g>
                              </g>
                            </svg>
                          </button>
                        </div>
                        <div class="alibaba-datepicker__container slide-left" data-v-65b601f8>
                          <div data-v-65b601f8 class="px-2 pb-2 pb-0-md">
                            <div
                              data-v-6b378218
                              data-v-65b601f8
                              class="calendar mx-auto calendar--jalaali rtl calendar--range"
                            >
                              <h4
                                data-v-6b378218
                                data-test="datepickerMonth"
                                class="mb-1 mt-2 mt-1-sm w-normal px-2 text-darker"
                              >
                                خرداد
                                <!---->
                              </h4>
                              <div data-v-6b378218>
                                <div data-v-6b378218 class="calendar__weekdays hidden-xs">
                                  <span
                                    data-v-6b378218
                                    data-test="datepickerWeekday"
                                    class="text-center"
                                  >ش</span>
                                  <span
                                    data-v-6b378218
                                    data-test="datepickerWeekday"
                                    class="text-center"
                                  >ی</span>
                                  <span
                                    data-v-6b378218
                                    data-test="datepickerWeekday"
                                    class="text-center"
                                  >د</span>
                                  <span
                                    data-v-6b378218
                                    data-test="datepickerWeekday"
                                    class="text-center"
                                  >س</span>
                                  <span
                                    data-v-6b378218
                                    data-test="datepickerWeekday"
                                    class="text-center"
                                  >چ</span>
                                  <span
                                    data-v-6b378218
                                    data-test="datepickerWeekday"
                                    class="text-center"
                                  >پ</span>
                                  <span
                                    data-v-6b378218
                                    data-test="datepickerWeekday"
                                    class="text-center"
                                  >ج</span>
                                </div>
                                <div data-v-6b378218 class="calendar__container">
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before first"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >1</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before holiday"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >2</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >3</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >4</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >5</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >6</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >7</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >8</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before holiday"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >9</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >10</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >11</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >12</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >13</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >14</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >15</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before holiday"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >16</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >17</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day today"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >18</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <span data-v-6b378218 class="btn-today"></span>
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >19</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >20</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >21</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >22</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day holiday"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >23</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >24</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >25</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >26</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >27</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >28</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >29</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day holiday"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >30</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day last"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >31</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                  </div>
                                </div>
                              </div>
                            </div>
                          </div>
                          <div data-v-65b601f8 class="px-2 pb-2 pb-0-md">
                            <div
                              data-v-6b378218
                              data-v-65b601f8
                              class="calendar mx-auto calendar--jalaali rtl calendar--range"
                            >
                              <h4
                                data-v-6b378218
                                data-test="datepickerMonth"
                                class="mb-1 mt-2 mt-1-sm w-normal px-2 text-darker"
                              >
                                تیر
                                <!---->
                              </h4>
                              <div data-v-6b378218>
                                <div data-v-6b378218 class="calendar__weekdays hidden-xs">
                                  <span
                                    data-v-6b378218
                                    data-test="datepickerWeekday"
                                    class="text-center"
                                  >ش</span>
                                  <span
                                    data-v-6b378218
                                    data-test="datepickerWeekday"
                                    class="text-center"
                                  >ی</span>
                                  <span
                                    data-v-6b378218
                                    data-test="datepickerWeekday"
                                    class="text-center"
                                  >د</span>
                                  <span
                                    data-v-6b378218
                                    data-test="datepickerWeekday"
                                    class="text-center"
                                  >س</span>
                                  <span
                                    data-v-6b378218
                                    data-test="datepickerWeekday"
                                    class="text-center"
                                  >چ</span>
                                  <span
                                    data-v-6b378218
                                    data-test="datepickerWeekday"
                                    class="text-center"
                                  >پ</span>
                                  <span
                                    data-v-6b378218
                                    data-test="datepickerWeekday"
                                    class="text-center"
                                  >ج</span>
                                </div>
                                <div data-v-6b378218 class="calendar__container">
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day first"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >1</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >2</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >3</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >4</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >5</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day holiday"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >6</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >7</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >8</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >9</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >10</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >11</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >12</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day holiday"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >13</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >14</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >15</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >16</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >17</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >18</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >19</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day holiday"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >20</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >21</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >22</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >23</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >24</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >25</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >26</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day holiday"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >27</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >28</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >29</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >30</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day last"
                                  >
                                    <span
                                      data-v-fc995ab2
                                      data-v-6b378218
                                      class="calendar__day__content"
                                    >31</span>
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                    <!---->
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                  </div>
                                  <div
                                    data-v-6b378218
                                    data-test="datepickerDay"
                                    class="calendar__day before"
                                  >
                                    <span data-v-6b378218 class="calendar__day__square"></span>
                                  </div>
                                </div>
                              </div>
                            </div>
                          </div>
                        </div>
                        <hr class="hidden-xs mb-1 mt-0" data-v-65b601f8 />
                        <footer class="alibaba-datepicker__footer rtl" data-v-65b601f8>
                          <div data-v-65b601f8>
                            <p
                              class="text-black w-500 font-12 m-0 hidden-xs"
                              data-v-65b601f8
                            >تاریخ انتخابی شما:</p>
                            <em data-v-65b601f8>---</em>
                          </div>
                          <div data-v-65b601f8>
                            <button
                              type="button"
                              disabled="disabled"
                              class="btn btn-block btn-orange py-1 w-500"
                              style="min-width: 90px;"
                              data-v-65b601f8
                            >تایید</button>
                          </div>
                        </footer>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="col-xs-4 col-sm-3 col-md-4 search-item-container" data-v-fc995ab2>
                  <div class="search-item no-border" data-v-fc995ab2>
                    <div class="search-item-input" data-v-fc995ab2>
                      <span class="text-gray mb-1 inline-block" data-v-fc995ab2>مسافران</span>
                      <input
                        type="text"
                        name="passengers"
                        placeholder="مسافران"
                        tabindex="5"
                        readonly="readonly"
                        value="2 بزرگسال ، 1 اتاق"
                        class="form-control notice inline-block"
                        data-v-fc995ab2
                      />
                      <span class="search-item-arrow" data-v-fc995ab2>
                        <svg
                          fill="currentCollor"
                          width="17px"
                          height="9px"
                          viewBox="0 0 17 9"
                          version="1.1"
                          xmlns="http://www.w3.org/2000/svg"
                          xmlns:xlink="http://www.w3.org/1999/xlink"
                          data-v-fc995ab2
                          class
                        >
                          <g stroke="none" stroke-width="1" fill="none" fill-rule="evenodd">
                            <g
                              id="International-Hotel---PDP---Desktop"
                              transform="translate(-1186.000000, -2842.000000)"
                              fill="#2D8AFF"
                              fill-rule="nonzero"
                            >
                              <g id="Group-22" transform="translate(195.000000, 2713.000000)">
                                <g id="search-hotel" transform="translate(5.000000, 66.000000)">
                                  <g id="Group-17" transform="translate(514.000000, 27.000000)">
                                    <g id="Group-35">
                                      <path
                                        d="M488.587927,36.3977476 L488.587927,36.3977476 C488.807597,36.6097808 488.813788,36.9597454 488.601754,37.1794153 C488.597227,37.1841056 488.592617,37.1887155 488.587927,37.1932427 L480.5,45 L472.412073,37.1932427 C472.192403,36.9812094 472.186212,36.6312448 472.398246,36.4115749 C472.402773,36.4068846 472.407383,36.4022748 472.412073,36.3977476 L472.412073,36.3977476 C472.641975,36.1758381 473.006317,36.1758381 473.236219,36.3977476 L480.5,43.4090097 L487.763781,36.3977476 C487.993683,36.1758381 488.358025,36.1758381 488.587927,36.3977476 Z"
                                        id="Rectangle-2-Copy"
                                        transform="translate(480.500000, 40.500000) rotate(-360.000000) translate(-480.500000, -40.500000) "
                                      />
                                    </g>
                                  </g>
                                </g>
                              </g>
                            </g>
                          </g>
                        </svg>
                      </span>
                    </div>
                  </div>
                  <div class="input-group hotel-passenger-picker" data-v-428b9aff data-v-fc995ab2>
                    <span class="input-group-addon" style="display:;" data-v-428b9aff>
                      <i class="icon icon-passenger" data-v-428b9aff></i>
                    </span>
                    <div class="v-dropdown mt-1" data-v-428b9aff>
                      <div
                        class="p-2 clearfix passenger-picker-dropdown pretty-scroll"
                        data-v-428b9aff
                      >
                        <div class="search-passengers-room" data-v-7c07d2e0 data-v-428b9aff>
                          <div class="p-2" data-v-7c07d2e0>
                            <!---->
                            <h5 class="inline text-orange w-500" data-v-7c07d2e0>اتاق اول</h5>
                          </div>
                          <div class="p-1 clearfix" data-v-7c07d2e0>
                            <strong class="w-500 ml-2" data-v-7c07d2e0>بزرگسال</strong>
                            <small class="text-gray" data-v-7c07d2e0>(12 سال به بالا)</small>
                            <div class="pull-left" data-v-7c07d2e0>
                              <span class="style-btn-increase inline-block" data-v-7c07d2e0></span>
                              <span
                                class="inline-block mx-1 text-center"
                                style="min-width: 12px;"
                                data-v-7c07d2e0
                              >2</span>
                              <span class="style-btn-decrease inline-block" data-v-7c07d2e0></span>
                            </div>
                          </div>
                          <div class="p-1 clearfix" data-v-7c07d2e0>
                            <strong class="w-500 ml-2" data-v-7c07d2e0>کودک</strong>
                            <small class="text-gray" data-v-7c07d2e0>(0 سال تا 12 سال)</small>
                            <div class="pull-left" data-v-7c07d2e0>
                              <span class="style-btn-increase inline-block" data-v-7c07d2e0></span>
                              <span
                                class="inline-block mx-1 text-center"
                                style="min-width: 12px;"
                                data-v-7c07d2e0
                              >0</span>
                              <span class="style-btn-decrease inline-block" data-v-7c07d2e0></span>
                            </div>
                          </div>
                          <!---->
                        </div>
                        <hr class="m-0" data-v-428b9aff />
                        <div class="m-2 mt-3" data-v-428b9aff>
                          <button
                            type="button"
                            class="btn btn-primary btn-outline btn-block"
                            data-v-428b9aff
                          >
                            <i class="icon-plus v-middle" data-v-428b9aff></i>
                            اضافه کردن اتاق
                          </button>
                        </div>
                      </div>
                    </div>
                    <input
                      type="text"
                      name="passengers"
                      placeholder="مسافران"
                      readonly="readonly"
                      aria-describedby="search-passengers"
                      value="2 بزرگسال ، 1 اتاق"
                      class="form-control"
                      data-v-428b9aff
                    />
                  </div>
                </div>
                <div
                  class="text-center pt-2 mb-3"
                  data-v-fc995ab2
                  data-v-21eb7522
                >برای مشاهده قیمت&zwnj;ها، تاریخ ورود و خروج خود را انتخاب کنید</div>
                <div
                  class="col-xs-2 col-sm-1 col-md-3 m-0 p-0 text-left search-button-container"
                  data-v-fc995ab2
                >
                  <button
                    disabled="disabled"
                    type="submit"
                    aria-label="Show rooms"
                    class="btn btn-info btn-search-panel"
                    data-v-fc995ab2
                  >
                    <span data-v-fc995ab2>مشاهده اتاق های موجود</span>
                  </button>
                </div>
              </div>
            </div>
            <div class="my-2" data-v-21eb7522>
              <div
                class="share-buttons flex flex-row flex-justify-space-between"
                data-v-ad6ebbbc
                data-v-21eb7522
              >
                <label data-v-ad6ebbbc>اشتراک&zwnj;گذاری این هتل</label>
                <ul class="share-buttons__buttons flex flex-row-reverse" data-v-ad6ebbbc>
                  <li class="share-buttons__button" data-v-ad6ebbbc>
                    <a
                      href="https://wa.me/?text=https%3A%2F%2Fwww.alibaba.ir%2Fhotel%2Ftr-istanbul%2Fakgun-istanbul"
                      target="blank"
                      aria-label="اشتراک با واتساپ"
                      class="share-button m-0 p-0 share-button--whatsapp has-tooltip"
                      data-v-02bb9b04
                      data-v-cf14f46c
                      data-v-ad6ebbbc
                      data-original-title="null"
                    >
                      <svg
                        xmlns="http://www.w3.org/2000/svg"
                        viewBox="0 0 32 32"
                        fill="currentColor"
                        aria-hidden="true"
                        focusable="false"
                        class="share-button__icon"
                        data-v-02bb9b04
                        data-v-cf14f46c
                      >
                        <path
                          d="M11.53,10.37a.86.86,0,0,1,1.34.31l1,2.19a.88.88,0,0,1-.11.87l-.49.64a.83.83,0,0,0-.07.93,12.34,12.34,0,0,0,4,3.5.85.85,0,0,0,.92-.19l.56-.57a.87.87,0,0,1,.85-.23l2.31.66a.86.86,0,0,1,.48,1.29,3.88,3.88,0,0,1-2.06,1.8c-1.58.38-4,0-7-2.82-2.62-2.44-3.31-4.48-3.14-6.09A3.82,3.82,0,0,1,11.53,10.37ZM16,6.58A9.32,9.32,0,0,0,6.68,15.9a9.22,9.22,0,0,0,1,4.23l.42.81-.78,3.77L11,23.83l.84.42a9.33,9.33,0,0,0,10.74-1.76A9.32,9.32,0,0,0,16,6.58ZM15.42,4A11.91,11.91,0,1,1,10.7,26.56L4.69,28a.47.47,0,0,1-.56-.55l1.26-6.13A11.92,11.92,0,0,1,15.42,4Z"
                        />
                      </svg>
                    </a>
                  </li>
                  <li class="share-buttons__button" data-v-ad6ebbbc>
                    <a
                      href="https://t.me/share/url?url=https%3A%2F%2Fwww.alibaba.ir%2Fhotel%2Ftr-istanbul%2Fakgun-istanbul&amp;text=Akg%C3%BCn%20Istanbul"
                      target="blank"
                      aria-label="اشتراک با تلگرام"
                      class="share-button m-0 p-0 share-button--telegram has-tooltip"
                      data-v-02bb9b04
                      data-v-2bebcbbe
                      data-v-ad6ebbbc
                      data-original-title="null"
                    >
                      <svg
                        xmlns="http://www.w3.org/2000/svg"
                        viewBox="0 0 32 32"
                        fill="currentColor"
                        aria-hidden="true"
                        focusable="false"
                        class="share-button__icon"
                        data-v-02bb9b04
                        data-v-2bebcbbe
                      >
                        <path
                          d="M13.42,19.18,13,24.77a1.41,1.41,0,0,0,1.11-.54l2.66-2.55,5.52,4c1,.57,1.73.27,2-.93l3.62-17h0c.32-1.5-.54-2.08-1.53-1.71L5.11,14.26c-1.45.56-1.43,1.37-.24,1.74l5.44,1.69L23,9.78c.6-.39,1.14-.18.69.22Z"
                        />
                      </svg>
                    </a>
                  </li>
                  <li class="share-buttons__button" data-v-ad6ebbbc>
                    <button
                      type="button"
                      aria-label="کپی لینک این هتل"
                      data-clipboard-text="https://www.alibaba.ir/hotel/tr-istanbul/akgun-istanbul"
                      class="share-button m-0 p-0 share-button--copy-to-clipboard has-tooltip"
                      data-v-02bb9b04
                      data-v-4db20817
                      data-v-ad6ebbbc
                      data-original-title="null"
                    >
                      <svg
                        xmlns="http://www.w3.org/2000/svg"
                        viewBox="0 0 32 32"
                        fill="currentColor"
                        aria-hidden="true"
                        focusable="false"
                        class="share-button__icon"
                        data-v-02bb9b04
                        data-v-4db20817
                      >
                        <path
                          d="M26,6.82A3,3,0,0,0,23,4H11a1,1,0,0,0,.12,2h12A1,1,0,0,1,24,7V23a1,1,0,0,0,2-.12V6.82Z"
                        />
                        <path
                          d="M19,8H9a3,3,0,0,0-3,3V25a3,3,0,0,0,3,3H19a3,3,0,0,0,3-3V11A3,3,0,0,0,19,8Zm1,17a1,1,0,0,1-1,1H9a1,1,0,0,1-1-1V11a1,1,0,0,1,1-1H19a1,1,0,0,1,1,1Z"
                        />
                      </svg>
                    </button>
                  </li>
                </ul>
              </div>
            </div>
          </div>
        </div>
        <!---->
        <!---->
      </div>
    </main>
  </div>
</template>

<script>
//import axios from "axios";

export default {
  data() {
    return {
      open: false,
      hotel:{}
    };
  },
  async asyncData({ route, params,$axios }) {
    return await $axios({
      method: "get",
      url: "/hotels/" + params.id
    })
      .then(data => {
          console.log(data.data)
        return { hotel: data.data }
      })
      .catch(e => console.log(e));
  },
  methods: {
    opendiv(op) {
      this.open = op;
    }
  }
};
</script>
<style scoped>
/*! https://cdn.alibaba.ir/dist/ff4aed11/b6a7be8e2b2971109726.css */
footer,
header,
main,
nav,
section {
  display: block;
}
a {
  background-color: transparent;
}
a:active,
a:hover {
  outline: 0;
}
small {
  font-size: 80%;
}
img {
  border: 0;
}
svg:not(:root) {
  overflow: hidden;
}
hr {
  box-sizing: content-box;
  height: 0;
}
button,
input {
  color: inherit;
  font: inherit;
  margin: 0;
}
button {
  overflow: visible;
}
button {
  text-transform: none;
}
button {
  -webkit-appearance: button;
  cursor: pointer;
}
button[disabled] {
  cursor: default;
}
button::-moz-focus-inner,
input::-moz-focus-inner {
  border: 0;
  padding: 0;
}
input {
  line-height: normal;
}
*,
:after,
:before {
  box-sizing: border-box;
}
button,
input {
  font-family: inherit;
  font-size: inherit;
  line-height: inherit;
}
a {
  color: #4990e2;
}
a:focus,
a:hover {
  color: #64b5f6;
}
a:focus {
  outline: 5px auto -webkit-focus-ring-color;
  outline-offset: -2px;
}
img {
  vertical-align: middle;
}
.img-rounded {
  border-radius: 5px;
}
hr {
  margin-top: 25px;
  margin-bottom: 25px;
  border: 0;
  border-top: 1px solid #f0f0f0;
}
[role="button"] {
  cursor: pointer;
}
h2,
h3,
h4,
h5 {
  font-family: inherit;
  font-weight: 700;
  line-height: 1.4;
  color: inherit;
}
h2,
h3 {
  margin-top: 25px;
  margin-bottom: 12.5px;
}
h4,
h5 {
  margin-top: 12.5px;
  margin-bottom: 12.5px;
}
h2 {
  font-size: 30px;
}
h3 {
  font-size: 24px;
}
h4 {
  font-size: 18px;
}
h5 {
  font-size: 14px;
}
p {
  margin: 0 0 12.5px;
}
small {
  font-size: 85%;
}
.text-left {
  text-align: left;
}
.text-right {
  text-align: right;
}
.text-center {
  text-align: center;
}
.text-nowrap {
  white-space: nowrap;
}
ol,
ul {
  margin-top: 0;
  margin-bottom: 12.5px;
}
.list-inline,
.list-unstyled {
  list-style: none;
}
.list-inline {
  margin-left: -5px;
}
.list-inline > li {
  display: inline-block;
  padding-left: 5px;
  padding-right: 5px;
}
.container {
  margin-right: auto;
  margin-left: auto;
  padding-left: 15px;
  padding-right: 15px;
}
@media (min-width: 768px) {
  .container {
    width: 750px;
  }
}
@media (min-width: 992px) {
  .container {
    width: 970px;
  }
}
@media (min-width: 1200px) {
  .container {
    width: 1170px;
  }
}
.row {
  margin-left: -15px;
  margin-right: -15px;
}
.col-xs-2,
.col-xs-3,
.col-xs-4,
.col-xs-6,
.col-xs-7,
.col-xs-10,
.col-xs-12 {
  float: left;
}
@media (min-width: 768px) {
  .col-sm-1,
  .col-sm-3,
  .col-sm-5 {
    float: left;
  }
  .col-sm-5 {
    width: 41.66666667%;
  }
  .col-sm-3 {
    width: 25%;
  }
  .col-sm-1 {
    width: 8.33333333%;
  }
}
@media (min-width: 992px) {
  .col-md-3,
  .col-md-4,
  .col-md-5,
  .col-md-9 {
    float: left;
  }
  .col-md-9 {
    width: 75%;
  }
  .col-md-5 {
    width: 41.66666667%;
  }
  .col-md-4 {
    width: 33.33333333%;
  }
  .col-md-3 {
    width: 25%;
  }
}
label {
  display: inline-block;
  max-width: 100%;
  margin-bottom: 5px;
  font-weight: 700;
}
.form-control {
  display: block;
  width: 100%;
  height: 39px;
  padding: 6px 12px;
  font-size: 14px;
  line-height: 1.8;
  color: #aaa;
  background-color: #fff;
  background-image: none;
  border: 1px solid #ccc;
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  transition: border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
}
.form-control:focus {
  border-color: #66afe9;
  outline: 0;
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075),
    0 0 8px rgba(102, 175, 233, 0.6);
}
.form-control::-moz-placeholder {
  color: #d2d2d2;
  opacity: 1;
}
.form-control:-ms-input-placeholder {
  color: #d2d2d2;
}
.form-control::-webkit-input-placeholder {
  color: #d2d2d2;
}
.form-control::-ms-expand {
  border: 0;
  background-color: transparent;
}
.form-control[readonly] {
  background-color: #f0f0f0;
  opacity: 1;
}
.btn {
  display: inline-block;
  margin-bottom: 0;
  font-weight: 400;
  text-align: center;
  vertical-align: middle;
  touch-action: manipulation;
  cursor: pointer;
  background-image: none;
  border: 1px solid transparent;
  white-space: nowrap;
  padding: 6px 12px;
  font-size: 14px;
  line-height: 1.8;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
}
.btn.active:focus,
.btn:active:focus,
.btn:focus {
  outline: 5px auto -webkit-focus-ring-color;
  outline-offset: -2px;
}
.btn:focus,
.btn:hover {
  color: #646464;
  text-decoration: none;
}
.btn.active,
.btn:active {
  outline: 0;
  background-image: none;
  box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
}
.btn[disabled] {
  cursor: not-allowed;
  opacity: 0.65;
  filter: alpha(opacity=65);
  box-shadow: none;
}
.btn-primary {
  color: #fff;
  background-color: #4990e2;
  border-color: #3383de;
}
.btn-primary:focus {
  color: #fff;
  background-color: #2276d6;
  border-color: #14457e;
}
.btn-primary:active,
.btn-primary:hover {
  color: #fff;
  background-color: #2276d6;
  border-color: #1d65b7;
}
.btn-primary:active:focus,
.btn-primary:active:hover {
  color: #fff;
  background-color: #1d65b7;
  border-color: #14457e;
}
.btn-primary:active {
  background-image: none;
}
.btn-info {
  color: #fff;
  background-color: #64b5f6;
  border-color: #4ca9f5;
}
.btn-info:focus {
  color: #fff;
  background-color: #349ef3;
  border-color: #0b6ab6;
}
.btn-info:active,
.btn-info:hover {
  color: #fff;
  background-color: #349ef3;
  border-color: #128ef1;
}
.btn-info:active:focus,
.btn-info:active:hover {
  color: #fff;
  background-color: #128ef1;
  border-color: #0b6ab6;
}
.btn-info:active {
  background-image: none;
}
.btn-info[disabled]:focus,
.btn-info[disabled]:hover {
  background-color: #64b5f6;
  border-color: #4ca9f5;
}
.btn-link {
  color: #4990e2;
  font-weight: 400;
  border-radius: 0;
}
.btn-link,
.btn-link:active {
  background-color: transparent;
  box-shadow: none;
}
.btn-link,
.btn-link:active,
.btn-link:focus,
.btn-link:hover {
  border-color: transparent;
}
.btn-link:focus,
.btn-link:hover {
  color: #64b5f6;
  text-decoration: none;
  background-color: transparent;
}
.btn-block {
  display: block;
  width: 100%;
}
.fade {
  opacity: 0;
  transition: opacity 0.15s linear;
}
.input-group {
  position: relative;
  display: table;
  border-collapse: separate;
}
.input-group .form-control {
  position: relative;
  z-index: 2;
  float: left;
  width: 100%;
  margin-bottom: 0;
}
.input-group .form-control:focus {
  z-index: 3;
}
.input-group-addon,
.input-group .form-control {
  display: table-cell;
}
.input-group-addon {
  width: 1%;
  white-space: nowrap;
  vertical-align: middle;
}
.input-group-addon {
  padding: 6px 12px;
  font-size: 14px;
  font-weight: 400;
  line-height: 1;
  color: #aaa;
  text-align: center;
  background-color: #f0f0f0;
  border: 1px solid #ccc;
  border-radius: 3px;
}
.input-group-addon:first-child,
.input-group .form-control:first-child {
  border-bottom-right-radius: 0;
  border-top-right-radius: 0;
}
.input-group-addon:first-child {
  border-right: 0;
}
.input-group .form-control:last-child {
  border-bottom-left-radius: 0;
  border-top-left-radius: 0;
}
.close {
  float: right;
  font-size: 21px;
  font-weight: 700;
  line-height: 1;
  color: #000;
  text-shadow: 0 1px 0 #fff;
  opacity: 0.2;
  filter: alpha(opacity=20);
}
.close:focus,
.close:hover {
  color: #000;
  text-decoration: none;
  cursor: pointer;
  opacity: 0.5;
  filter: alpha(opacity=50);
}
button.close {
  padding: 0;
  cursor: pointer;
  background: transparent;
  border: 0;
  -webkit-appearance: none;
}
.clearfix:after,
.clearfix:before,
.container:after,
.container:before,
.row:after,
.row:before {
  content: " ";
  display: table;
}
.clearfix:after,
.container:after,
.row:after {
  clear: both;
}
.pull-right {
  float: right !important;
}
.pull-left {
  float: left !important;
}
.hidden {
  display: none !important;
}
.visible-xs {
  display: none !important;
}
@media (max-width: 767px) {
  .visible-xs {
    display: block !important;
  }
}
@media (max-width: 767px) {
  .hidden-xs {
    display: none !important;
  }
}
@media (min-width: 768px) and (max-width: 991px) {
  .hidden-sm {
    display: none !important;
  }
}
@media (min-width: 992px) and (max-width: 1199px) {
  .hidden-md {
    display: none !important;
  }
}
@media (min-width: 1200px) {
  .hidden-lg {
    display: none !important;
  }
}
.list-inline,
.list-unstyled {
  padding-right: 0;
  padding-left: 0;
}
.list-inline {
  margin-right: -5px;
  margin-left: 0;
}
.col-md-3,
.col-md-4,
.col-md-5,
.col-md-9,
.col-sm-1,
.col-sm-3,
.col-sm-5,
.col-xs-2,
.col-xs-3,
.col-xs-4,
.col-xs-6,
.col-xs-7,
.col-xs-10,
.col-xs-12 {
  position: relative;
  min-height: 1px;
  padding-left: 15px;
  padding-right: 15px;
}
.col-xs-2,
.col-xs-3,
.col-xs-4,
.col-xs-6,
.col-xs-7,
.col-xs-10,
.col-xs-12 {
  float: right;
}
.col-xs-12 {
  width: 100%;
}
.col-xs-10 {
  width: 83.33333333%;
}
.col-xs-7 {
  width: 58.33333333%;
}
.col-xs-6 {
  width: 50%;
}
.col-xs-4 {
  width: 33.33333333%;
}
.col-xs-3 {
  width: 25%;
}
.col-xs-2 {
  width: 16.66666667%;
}
@media (min-width: 768px) {
  .col-sm-1,
  .col-sm-3,
  .col-sm-5 {
    float: right;
  }
  .col-sm-5 {
    width: 41.66666667%;
  }
  .col-sm-3 {
    width: 25%;
  }
  .col-sm-1 {
    width: 8.33333333%;
  }
}
@media (min-width: 992px) {
  .col-md-3,
  .col-md-4,
  .col-md-5,
  .col-md-9 {
    float: right;
  }
  .col-md-9 {
    width: 75%;
  }
  .col-md-5 {
    width: 41.66666667%;
  }
  .col-md-4 {
    width: 33.33333333%;
  }
  .col-md-3 {
    width: 25%;
  }
}
.input-group .form-control {
  float: right;
}
.input-group-addon:first-child,
.input-group .form-control:first-child {
  border-bottom-right-radius: 4px;
  border-top-right-radius: 4px;
  border-bottom-left-radius: 0;
  border-top-left-radius: 0;
}
.input-group-addon:first-child {
  border-left: 0;
  border-right: 1px solid;
}
.input-group .form-control:last-child {
  border-bottom-left-radius: 4px;
  border-top-left-radius: 4px;
  border-bottom-right-radius: 0;
  border-top-right-radius: 0;
}
.close {
  float: left;
}
@media (min-width: 1200px) {
  .container {
    width: 1200px;
  }
}
input[type="text"] {
  -webkit-appearance: none;
}
.btn {
  border-radius: 5px;
  transition: all 0.25s;
}
.btn:focus {
  outline: 0;
}
.btn.btn-outline {
  background-color: transparent;
}
.btn[disabled],
.btn[disabled]:hover {
  background-color: #aaa;
  border-color: #aaa;
}
.btn-primary.btn-outline {
  color: #4990e2;
}
.btn-primary.btn-outline:focus,
.btn-primary.btn-outline:hover {
  color: #3383de;
  border-color: #3383de;
}
.btn-orange {
  border: none !important;
  box-shadow: none !important;
  background-size: 140%;
  background-position: 100%;
  background-repeat: no-repeat;
  transition: all 0.2s ease-in-out 0s;
}
.btn-orange[disabled] {
  cursor: not-allowed;
}
.btn-orange:not(disabled) {
  cursor: pointer;
}
.btn-orange:not(disabled):active:hover,
.btn-orange:not(disabled):focus,
.btn-orange:not(disabled):hover {
  border: none !important;
  box-shadow: none !important;
  background-color: #ff8200;
  color: #fff;
}
.btn-raw {
  background-color: transparent;
  border: 0;
}
.form-control {
  border-radius: 3px;
  border-color: #d2d2d2;
  box-shadow: none;
  color: #646464;
}
.form-control:focus {
  outline: 0;
  box-shadow: none;
  border-color: inherit;
}
.input-group .form-control {
  z-index: 0;
}
.p-1 {
  padding: 5px !important;
}
.p-2 {
  padding: 10px !important;
}
.m-2 {
  margin: 10px !important;
}
.p-0 {
  padding: 0 !important;
}
.m-0 {
  margin: 0 !important;
}
.ml-2 {
  margin-left: 10px !important;
}
.ml-5 {
  margin-left: 60px !important;
}
.pl-0 {
  padding-left: 0 !important;
}
.pr-3 {
  padding-right: 20px !important;
}
.pr-0 {
  padding-right: 0 !important;
}
.mt-1 {
  margin-top: 5px !important;
}
.pt-2 {
  padding-top: 10px !important;
}
.mt-2 {
  margin-top: 10px !important;
}
.mt-3 {
  margin-top: 20px !important;
}
.mt-4 {
  margin-top: 40px !important;
}
.mt-0 {
  margin-top: 0 !important;
}
.mb-1 {
  margin-bottom: 5px !important;
}
.pb-2 {
  padding-bottom: 10px !important;
}
.pb-3 {
  padding-bottom: 20px !important;
}
.mb-3 {
  margin-bottom: 20px !important;
}
.mb-4 {
  margin-bottom: 40px !important;
}
.mb-0 {
  margin-bottom: 0 !important;
}
.py-1 {
  padding-top: 5px !important;
  padding-bottom: 5px !important;
}
.my-1 {
  margin-top: 5px !important;
  margin-bottom: 5px !important;
}
.my-2 {
  margin-top: 10px !important;
  margin-bottom: 10px !important;
}
.py-3 {
  padding-top: 20px !important;
  padding-bottom: 20px !important;
}
.px-1 {
  padding-left: 5px !important;
  padding-right: 5px !important;
}
.mx-1 {
  margin-left: 5px !important;
  margin-right: 5px !important;
}
.px-2 {
  padding-left: 10px !important;
  padding-right: 10px !important;
}
.px-3 {
  padding-left: 20px !important;
  padding-right: 20px !important;
}
.mx-auto {
  margin-left: auto !important;
  margin-right: auto !important;
}
.px-0 {
  padding-left: 0 !important;
  padding-right: 0 !important;
}
@media (min-width: 768px) {
  .mt-1-sm {
    margin-top: 5px !important;
  }
}
@media (min-width: 768px) {
  .mb-3-sm {
    margin-bottom: 20px !important;
  }
}
@media (min-width: 992px) {
  .pb-0-md {
    padding-bottom: 0 !important;
  }
  .mb-0-md {
    margin-bottom: 0 !important;
  }
}
.font-12 {
  font-size: 12px !important;
}
[class*="icon-"],
[class^="icon-"] {
  font-family: alibaba !important;
  speak: none;
  font-style: normal;
  font-weight: 400;
  -webkit-font-feature-settings: normal;
  font-feature-settings: normal;
  font-variant: normal;
  text-transform: none;
  line-height: 1;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}
.icon-arrow-left:before {
  content: "\e920";
}
.icon-arrow-right:before {
  content: "\e921";
}
.icon-plus:before {
  content: "\e924";
}
.icon-star-rate:before {
  content: "\e929";
}
.icon-arrow-up-16:before {
  content: "\e939";
}
.icon-arrow-down-16:before {
  content: "\e93a";
}
.icon-passenger:before {
  content: "\e944";
}
.flex {
  display: flex !important;
}
.flex-row {
  flex-direction: row;
}
.flex-row-reverse {
  flex-direction: row-reverse;
}
.flex-justify-space-between {
  justify-content: space-between;
}
.flex-1 {
  flex-grow: 1;
}
h2,
h3,
h4,
h5 {
  font-family: IranSans, sans-serif;
  font-weight: 700;
  line-height: 1.4;
  margin: 1.44em 0 0.5em;
}
h2 {
  font-size: 1.728em;
}
h3 {
  font-size: 1.44em;
}
h4 {
  font-size: 1.2em;
}
h5 {
  font-size: 1em;
}
p {
  font-size: 1em;
  margin: 0 0 1.5em;
}
a {
  color: #2979ff;
  transition: all 0.25s;
}
a:hover {
  color: #64b5f6;
  text-decoration: none;
}
.text-gray {
  color: #aaa;
}
.text-dark {
  color: #646464;
}
.text-darker {
  color: #424242;
}
.text-black {
  color: #212121;
}
.text-orange {
  color: orange;
}
.text-blue {
  color: #2979ff;
}
.w-normal {
  font-weight: 400;
}
.w-500 {
  font-weight: 500;
}
.font-en {
  font-family: sans-serif;
}
.pretty-scroll::-webkit-scrollbar,
.v-dropdown::-webkit-scrollbar {
  width: 5px;
}
.pretty-scroll::-webkit-scrollbar-track,
.v-dropdown::-webkit-scrollbar-track {
  background: transparent;
}
.pretty-scroll::-webkit-scrollbar-thumb,
.v-dropdown::-webkit-scrollbar-thumb {
  background: #d2d2d2;
  border-radius: 4px;
}
.v-dropdown {
  position: absolute;
  top: 100%;
  right: 0;
  background-color: #fff;
  display: none;
  z-index: 500;
  border-radius: 3px;
  box-shadow: 0 0 6px rgba(0, 0, 0, 0.15);
}
.v-dropdown.fade {
  -webkit-animation-name: fadeIn;
  animation-name: fadeIn;
  -webkit-animation-iteration-count: 1;
  animation-iteration-count: 1;
  -webkit-animation-duration: 0.2s;
  animation-duration: 0.2s;
  -webkit-animation-delay: 0s;
  animation-delay: 0s;
  -webkit-animation-timing-function: ease;
  animation-timing-function: ease;
  -webkit-animation-fill-mode: both;
  animation-fill-mode: both;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}
.style-btn-decrease,
.style-btn-increase {
  width: 30px;
  height: 30px;
  line-height: 30px;
  padding-top: 1px;
  font-size: 1.1em;
  text-align: center;
  border: 1px solid orange;
  color: orange;
  border-radius: 100%;
  cursor: pointer;
  background-color: transparent;
  transition: all 0.15s ease;
}
.style-btn-decrease:before,
.style-btn-increase:before {
  content: "+";
}
.style-btn-decrease:active,
.style-btn-increase:active {
  background-color: orange;
  color: #fff;
}
.style-btn-decrease:before {
  content: "-";
}
.btn {
  border-radius: 3px;
}
.btn-orange {
  border: 1px solid orange;
  background-color: orange;
  color: #fff;
}
.btn-orange:hover {
  background-color: #cc8400;
  color: #fff;
}
.btn-orange[disabled] {
  border-color: #646464;
}
.btn-info {
  background-color: #2979ff;
  border-color: #2979ff;
  color: #fff !important;
}
.btn-info:hover {
  background-color: #005cf5;
}
.box hr {
  margin: 0 -30px 10px;
  border-top: 1px dashed #d2d2d2;
}
a:focus,
button:focus {
  outline: 0 !important;
  text-decoration: none;
}
a,
a:focus,
a:hover {
  cursor: pointer;
  text-decoration: none;
}
strong {
  font-weight: 700;
}
em,
i {
  font-style: italic;
}
img {
  max-width: 100%;
}
label {
  font-weight: 300;
}
.ltr {
  direction: ltr !important;
}
.rtl {
  direction: rtl !important;
}
.notice {
  font-weight: 500;
}
.relative {
  position: relative !important;
}
.inline {
  display: inline;
}
.inline-block {
  display: inline-block;
}
.block {
  display: block;
}
.svg-icon {
  display: inline-block;
  vertical-align: middle;
}
span.svg-icon > svg {
  display: block;
  margin-left: auto;
  margin-right: auto;
}
.bg-gray {
  background-color: #f5f5f5;
}
.box {
  margin: 3em auto;
  background-color: #fff;
  padding: 0 30px 15px;
  border-radius: 3px;
  box-shadow: 0 -1px 1px 0 rgba(0, 0, 0, 0.05), 0 1px 5px 0 rgba(0, 0, 0, 0.15);
}
.v-middle {
  vertical-align: middle !important;
}
.mirror-x {
  transform: scaleX(-1);
}
.no-border {
  border: none !important;
}
.inh-main li {
  list-style: none;
}
.inh-main ol,
.inh-main ul {
  margin: 0;
  padding: 0;
}
/*! https://cdn.alibaba.ir/dist/ff4aed11/a7670b144bc807c4b052.css */
.c-read-more[data-v-539448ea] {
  display: block;
  position: relative;
}
.c-read-more .half-text[data-v-539448ea],
.c-read-more[data-v-539448ea] {
  overflow: hidden;
}
.half-text {
  height: 32.5rem;
}
.c-read-more .half-text[data-v-539448ea]:after {
  content: " ";
  height: 50px;
  position: absolute;
  bottom: 35px;
  left: 0;
  right: 0;
  background: linear-gradient(hsla(0, 0%, 97.6%, 0.5), #f5f5f5);
}
.c-read-more .read-more-wrapper[data-v-539448ea] {
  text-align: center;
  margin-top: 10px;
}
.c-read-more .read-more-button[data-v-539448ea] {
  background: transparent;
  border: none;
  cursor: pointer;
  color: #2979ff;
}
.c-read-more .read-more-button i[data-v-539448ea] {
  vertical-align: middle;
}
.rate-stars[data-v-02a24b22] {
  font-size: 0.7em;
  color: #aaa;
  display: inline-block;
}
.rate-stars .icon-star-rate[data-v-02a24b22] {
  color: #d2d2d2;
  padding: 0 2.5px;
}
.rate-stars .icon-star-rate.active[data-v-02a24b22] {
  color: #ffc800;
}
.search-passengers-room[data-v-7c07d2e0] {
  padding: 0 0 20px;
}
.v-dropdown[data-v-428b9aff] {
  min-width: 320px;
  margin-top: 5px;
}
@media (min-width: 992px) {
  .v-dropdown[data-v-428b9aff] {
    right: auto;
    left: 0;
  }
}
.v-dropdown[data-v-428b9aff]:before {
  content: "";
  display: block;
  width: 0;
  height: 0;
  border: 5px solid transparent;
  border-bottom-color: #fff;
  position: absolute;
  top: -10px;
  left: 10px;
  z-index: 21;
}
@media (min-width: 1200px) {
  .v-dropdown[data-v-428b9aff]:before {
    right: 145px;
    left: auto;
  }
}
.passenger-picker-dropdown[data-v-428b9aff] {
  overflow-x: hidden;
  overflow-y: auto;
  max-height: 35vh;
}
.calendar[data-v-6b378218] {
  max-width: 340px;
}
.calendar > h4[data-v-6b378218] {
  font-size: 13px;
  text-align: center;
  font-weight: 400;
}
.calendar__weekdays[data-v-6b378218] {
  display: flex;
  padding: 10px 0;
  font-size: 0.8em;
}
.calendar__weekdays > span[data-v-6b378218] {
  flex: 1;
  text-align: center;
}
.calendar__container[data-v-6b378218] {
  display: flex;
  flex-wrap: wrap;
}
.calendar__day[data-v-6b378218] {
  flex: 14.28571% 0 1;
  font-size: 15px;
  cursor: pointer;
  border: 1px solid transparent;
  background-color: transparent;
  margin: 2px 0;
  color: #616161;
  font-weight: 400;
}
.calendar__day[data-v-6b378218],
.calendar__day__content[data-v-6b378218] {
  display: flex;
  align-items: center;
  justify-content: center;
  position: relative;
}
.calendar__day__content[data-v-6b378218] {
  z-index: 5;
  width: 100%;
  height: 100%;
}
.calendar__day__square[data-v-6b378218] {
  content: " ";
  display: block;
  padding-bottom: 100%;
}
.calendar__day.holiday[data-v-6b378218] {
  color: #f32415;
}
.calendar__day[data-v-6b378218]:active:after,
.calendar__day[data-v-6b378218]:hover:after {
  content: " ";
  display: block;
  position: absolute;
  top: -1px;
  left: -1px;
  right: -1px;
  bottom: -1px;
  border: 2px solid #ffbe47;
  border-radius: 4px;
  z-index: 3;
  transition: background-color 0.12s linear;
  background-color: #fff;
}
@media (max-width: 767px) {
  .calendar__day[data-v-6b378218]:hover:after {
    border-color: transparent;
  }
}
.calendar__day[data-v-6b378218]:active:after {
  background-color: #cc8400;
}
.calendar__day.before[data-v-6b378218] {
  opacity: 0.44;
  cursor: default;
  border-color: transparent;
  background-color: transparent;
}
.calendar__day.before[data-v-6b378218]:after {
  content: none;
  display: none;
}
.calendar__day .btn-today[data-v-6b378218] {
  position: absolute;
  top: 0;
  right: 0;
  left: 0;
  bottom: 0;
}
.btn-today {
  border: 1px dotted #e1e1e1;
  position: relative;
  border-radius: 4px;
}
.btn-today:before {
  content: " ";
  display: block;
  position: absolute;
  top: -6px;
  right: -6px;
  border: 6px solid transparent;
  border-bottom-color: inherit;
  transform: rotate(45deg);
}
.alibaba-datepicker[data-v-65b601f8] {
  z-index: auto;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
}
@media (min-width: 768px) {
  .alibaba-datepicker[data-v-65b601f8] {
    position: relative;
  }
}
@media (max-width: 767px) {
  .alibaba-datepicker__wrapper[data-v-65b601f8] {
    -webkit-animation-name: fadeIn-data-v-65b601f8;
    animation-name: fadeIn-data-v-65b601f8;
    -webkit-animation-iteration-count: 1s;
    animation-iteration-count: 1s;
    -webkit-animation-duration: 0.25s;
    animation-duration: 0.25s;
    -webkit-animation-delay: 0s;
    animation-delay: 0s;
    -webkit-animation-timing-function: ease;
    animation-timing-function: ease;
    -webkit-animation-fill-mode: both;
    animation-fill-mode: both;
    -webkit-backface-visibility: hidden;
    backface-visibility: hidden;
  }
}
.alibaba-datepicker__wrapper[data-v-65b601f8] {
  position: fixed;
  top: 0;
  left: 0;
  height: 100%;
  width: 100%;
  background-color: #fff;
  overflow: auto;
  z-index: 5000;
}
.alibaba-datepicker__wrapper > div[data-v-65b601f8] {
  padding: 95px 10px 40px;
}
@media (min-width: 370px) {
  .alibaba-datepicker__wrapper[data-v-65b601f8] {
    width: auto;
    height: auto;
    right: 10px;
    left: 10px;
    top: 10px;
    bottom: 10px;
  }
}
@media (min-width: 768px) {
  .alibaba-datepicker__wrapper[data-v-65b601f8] {
    position: absolute;
    padding: 15px 15px 10px;
    top: 100%;
    right: 50%;
    transform: translateX(50%);
    margin-top: 5px;
    width: 550px;
    height: auto;
    bottom: auto;
    overflow: hidden;
  }
  .alibaba-datepicker__wrapper.left[data-v-65b601f8] {
    transform: none;
    left: 0;
    right: auto;
  }
  .alibaba-datepicker__wrapper > div[data-v-65b601f8] {
    padding: 0;
  }
}
.alibaba-datepicker__container[data-v-65b601f8] {
  display: flex;
  flex-wrap: wrap;
  justify-content: flex-start;
  position: absolute;
  top: 100px;
  left: 0;
  right: 0;
  bottom: 105px;
  overflow: auto;
  padding: 10px;
}
.alibaba-datepicker__container.slide-left[data-v-65b601f8] {
  justify-content: flex-end;
}
.alibaba-datepicker__container > div[data-v-65b601f8] {
  flex: 100% 1 1;
  transition: transform 0.16s linear;
  position: relative;
}
.alibaba-datepicker__container > div[data-v-65b601f8]:not(:last-child):after {
  content: " ";
  position: absolute;
  display: block;
  background-color: #f1f6f8;
  bottom: 0;
  left: 0;
  right: 0;
  height: 1px;
}
@media (min-width: 768px) {
  .alibaba-datepicker__container > div[data-v-65b601f8]:not(:last-child):after {
    top: 40px;
    bottom: 10px;
    width: 1px;
    right: auto;
    height: auto;
  }
}
@media (min-width: 768px) {
  .alibaba-datepicker__container[data-v-65b601f8] {
    position: static;
    overflow: hidden;
    flex-wrap: nowrap;
    padding: 0;
    margin: 0 -10px;
  }
  .alibaba-datepicker__container > div[data-v-65b601f8] {
    flex: 50% 0 0;
  }
}
.alibaba-datepicker__arrows[data-v-65b601f8] {
  position: absolute;
  left: 0;
  right: 0;
  display: flex;
  z-index: 8;
  justify-content: space-between;
  padding: 0 15px;
}
.alibaba-datepicker__arrows > button[data-v-65b601f8] {
  display: inline-block;
  color: #979797;
  background-color: #f7f7f7;
  border: 1px solid #f1f6f8;
  padding: 7px;
  border-radius: 4px;
}
.alibaba-datepicker__arrows > button[data-v-65b601f8]:disabled {
  cursor: not-allowed;
}
.alibaba-datepicker__header[data-v-65b601f8] {
  position: absolute;
  top: 0;
  left: 0;
  right: 0;
  z-index: 12;
  font-family: IranSans, Tahoma, serif;
}
.alibaba-datepicker__header > div[data-v-65b601f8] {
  display: flex;
  position: relative;
  z-index: 14;
  align-items: center;
}
.alibaba-datepicker__header > div > button[data-v-65b601f8],
.alibaba-datepicker__header > div > span[data-v-65b601f8] {
  flex: 1;
}
.alibaba-datepicker__header .close[data-v-65b601f8] {
  font-size: 32px;
  padding: 12px;
  opacity: 1;
  color: orange;
  position: static;
}
.alibaba-datepicker__header .btn[data-v-65b601f8] {
  padding: 0 12px;
}
.alibaba-datepicker__header .btn.active[data-v-65b601f8] {
  font-weight: 500;
  color: #2979ff;
  outline: none;
  box-shadow: none;
}
@media (min-width: 768px) {
  .alibaba-datepicker__header[data-v-65b601f8] {
    position: static;
    border-bottom: 1px solid #f1f6f8;
    margin-top: -5px;
    margin-bottom: 15px;
    padding-bottom: 8px;
    font-size: 13px;
  }
}
.alibaba-datepicker .btn[data-v-65b601f8] {
  font-size: inherit;
}
.alibaba-datepicker__footer[data-v-65b601f8] {
  position: absolute;
  bottom: 0;
  left: 0;
  right: 0;
  background-color: #fff;
  padding: 10px;
  z-index: 12;
  box-shadow: 0 -15px 35px rgba(0, 0, 0, 0.06);
  font-family: IranSans, Tahoma, serif;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  align-items: stretch;
  font-size: 13px;
}
.alibaba-datepicker__footer .btn[data-v-65b601f8] {
  font-size: 1.23em;
}
@media (min-width: 768px) {
  .alibaba-datepicker__footer[data-v-65b601f8] {
    flex-direction: row;
    align-items: center;
    position: static;
    padding: 0;
    box-shadow: none;
  }
  .alibaba-datepicker__footer .btn[data-v-65b601f8] {
    font-size: 1em;
  }
}
.alibaba-datepicker hr[data-v-65b601f8] {
  border-color: #f1f6f8;
}
.form-control[data-v-fc995ab2] {
  height: 20px;
  width: calc(100% - 17px);
  font-weight: 700;
}
@media (max-width: 767px) {
  .form-control[data-v-fc995ab2] {
    height: 30px;
  }
}
.c-search-room[data-v-fc995ab2] {
  background-color: #fff;
  border-radius: 4px;
  border: 1px solid hsla(0, 0%, 59.2%, 0.2);
  padding: 15px;
  margin: 0;
  box-shadow: none;
}
.c-search-room .hotel-passenger-picker[data-v-fc995ab2] {
  width: 100%;
  right: 0;
}
.c-search-room .hotel-passenger-picker[data-v-fc995ab2] .v-dropdown {
  top: 40px;
  right: 0;
}
.c-search-room .hotel-passenger-picker[data-v-fc995ab2] .input-group-addon,
.c-search-room .hotel-passenger-picker[data-v-fc995ab2] input {
  display: none;
}
.c-search-room .search-items-wrapper[data-v-fc995ab2] {
  height: 100%;
  width: 100%;
  display: block;
  align-items: center;
}
.c-search-room .search-items-wrapper .search-button-container[data-v-fc995ab2] {
  text-align: center;
  position: inherit;
  width: 100%;
}
.c-search-room
  .search-items-wrapper
  .search-button-container
  .btn-search-panel[data-v-fc995ab2] {
  float: none;
  width: 100%;
}
.c-search-room .search-items-wrapper .search-item-container[data-v-fc995ab2] {
  position: inherit;
  padding: 10px 0;
  display: block;
  float: none;
  width: 100%;
  height: auto;
  border: 1px solid hsla(0, 0%, 59.2%, 0.2);
  border-radius: 1px;
  margin-bottom: 15px;
}
.c-search-room
  .search-items-wrapper
  .search-item-container
  .search-item[data-v-fc995ab2] {
  display: block;
  flex-direction: column;
  justify-content: space-around;
  align-items: center;
  padding: 0 15px 0 6px;
  border-left: 1px solid hsla(0, 0%, 59.2%, 0.2);
  height: 100%;
}
.c-search-room
  .search-items-wrapper
  .search-item-container
  .search-item[data-v-fc995ab2]:hover {
  cursor: pointer;
}
.c-search-room
  .search-items-wrapper
  .search-item-container
  .search-item
  .search-item-input[data-v-fc995ab2] {
  width: 100%;
  display: inline-block;
}
.c-search-room
  .search-items-wrapper
  .search-item-container
  .search-item
  .search-item-arrow[data-v-fc995ab2] {
  height: 8px;
  width: 16px;
  float: left;
}
.c-search-room
  .search-items-wrapper
  .search-item-container
  .search-item
  .search-item-arrow[data-v-fc995ab2]:hover {
  cursor: pointer;
}
.c-search-room .search-items-wrapper .btn-search-panel[data-v-fc995ab2] {
  height: 42px;
  border-radius: 5px;
  width: 160px;
}
.c-search-room input[data-v-fc995ab2] {
  background: #fff;
  border: none;
  padding: 6px 0;
  cursor: pointer;
}
.c-search-room .form-control[data-v-fc995ab2] {
  padding: 0;
  font-weight: 700;
  height: 20px;
}
@media (min-width: 992px) {
  .c-search-room
    .search-items-wrapper
    .search-item-container
    .search-item[data-v-fc995ab2] {
    flex-direction: row;
    justify-content: space-around;
    align-items: center;
  }
  .c-search-room
    .search-items-wrapper
    .search-item-container
    .search-item
    .search-item-input[data-v-fc995ab2] {
    font-size: 15px;
    text-align: right;
  }
  .c-search-room
    .search-items-wrapper
    .search-item-container
    .search-item
    .search-item-input
    input[data-v-fc995ab2] {
    cursor: pointer;
  }
  .c-search-room
    .search-items-wrapper
    .search-item-container
    .search-item
    .search-item-arrow[data-v-fc995ab2] {
    align-self: flex-end;
    margin-bottom: 8px;
  }
  .c-search-room .search-items-wrapper .btn-search-panel[data-v-fc995ab2] {
    height: 42px;
    border-radius: 5px;
    width: 192px;
    margin-top: 7px;
  }
}
.hotel-facilities[data-v-1150f8fd] {
  width: calc(100% - 45px);
  vertical-align: top;
  border-right: 1px solid #e5e5e5;
}
.next-prev-arrow {
  padding: 8px 0;
  text-align: center;
  background-color: #fff;
  width: 115px;
  overflow: auto;
}
.next-prev-arrow > i {
  width: 50%;
  float: right;
  display: inline-block;
  color: #000;
  padding: 7px;
  cursor: pointer;
}
.next-prev-arrow > i:first-child {
  border-left: 1px solid #e1e1e1;
}
.background[data-v-638cc802] {
  position: relative;
  background-size: cover;
  background-repeat: no-repeat;
  background-position: 50%;
  min-height: 250px;
}
@media (min-width: 768px) {
  .background[data-v-638cc802] {
    min-height: 290px;
  }
}
@media (min-width: 992px) {
  .background[data-v-638cc802] {
    min-height: 460px;
  }
}
.background--bottom-text > div[data-v-638cc802]:first-child,
.background--bottom-text[data-v-638cc802] > :first-child {
  position: absolute;
  bottom: 0;
  right: 0;
  left: 0;
  margin: 0;
  color: #fff;
  background-image: linear-gradient(transparent, #000);
}
.hv-image[data-v-638cc802] {
  background-size: cover;
  position: relative;
  cursor: pointer;
  padding-bottom: 77%;
  overflow: hidden;
}
.hv-image > div[data-v-638cc802] {
  position: absolute;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  background-color: rgba(0, 0, 0, 0.7);
  opacity: 0;
  color: #fff;
  text-align: center;
  transition: all 0.2s ease;
  vertical-align: middle;
  padding-top: 20px;
  font-size: 12px;
}
.hv-image > div[data-v-638cc802]:before {
  content: " ";
  display: inline-block;
  vertical-align: middle;
  height: 100%;
  width: 1px;
}
.hv-image.hovered > div[data-v-638cc802],
.hv-image:hover > div[data-v-638cc802] {
  padding-top: 0;
  opacity: 1;
}
.gallery-thumbnail[data-v-638cc802] {
  display: flex;
  flex-direction: row-reverse;
  margin: 0 -5px;
}
.gallery-thumbnail > div[data-v-638cc802] {
  width: 15%;
  padding: 5px;
}
.show-gallery[data-v-638cc802] {
  border: 1px solid #424242;
}
.show-gallery > div[data-v-638cc802] {
  background: inherit;
  color: #424242;
}
.leaflet-layer,
.leaflet-marker-icon,
.leaflet-pane,
.leaflet-tile,
.leaflet-tile-container {
  position: absolute;
  left: 0;
  top: 0;
}
.leaflet-container {
  overflow: hidden;
}
.leaflet-marker-icon,
.leaflet-tile {
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
  -webkit-user-drag: none;
}
.leaflet-marker-icon {
  display: block;
}
.leaflet-container .leaflet-marker-pane img,
.leaflet-container .leaflet-tile,
.leaflet-container .leaflet-tile-pane img {
  max-width: none !important;
  max-height: none !important;
}
.leaflet-container.leaflet-touch-zoom {
  touch-action: pan-x pan-y;
}
.leaflet-container.leaflet-touch-drag {
  touch-action: none;
  touch-action: pinch-zoom;
}
.leaflet-container.leaflet-touch-drag.leaflet-touch-zoom {
  touch-action: none;
}
.leaflet-container {
  -webkit-tap-highlight-color: transparent;
}
.leaflet-container a {
  -webkit-tap-highlight-color: rgba(51, 181, 229, 0.4);
}
.leaflet-tile {
  -webkit-filter: inherit;
  filter: inherit;
  visibility: hidden;
}
.leaflet-tile-loaded {
  visibility: inherit;
}
.leaflet-pane {
  z-index: 400;
}
.leaflet-tile-pane {
  z-index: 200;
}
.leaflet-overlay-pane {
  z-index: 400;
}
.leaflet-shadow-pane {
  z-index: 500;
}
.leaflet-marker-pane {
  z-index: 600;
}
.leaflet-tooltip-pane {
  z-index: 650;
}
.leaflet-popup-pane {
  z-index: 700;
}
.leaflet-control {
  position: relative;
  z-index: 800;
  pointer-events: visiblePainted;
  pointer-events: auto;
}
.leaflet-bottom,
.leaflet-top {
  position: absolute;
  z-index: 1000;
  pointer-events: none;
}
.leaflet-top {
  top: 0;
}
.leaflet-right {
  right: 0;
}
.leaflet-bottom {
  bottom: 0;
}
.leaflet-left {
  left: 0;
}
.leaflet-control {
  float: left;
  clear: both;
}
.leaflet-top .leaflet-control {
  margin-top: 10px;
}
.leaflet-left .leaflet-control {
  margin-left: 10px;
}
.leaflet-fade-anim .leaflet-tile {
  will-change: opacity;
}
.leaflet-zoom-animated {
  transform-origin: 0 0;
}
.leaflet-interactive {
  cursor: pointer;
}
.leaflet-grab {
  cursor: -webkit-grab;
  cursor: grab;
}
.leaflet-control,
.leaflet-popup-pane {
  cursor: auto;
}
.leaflet-marker-icon,
.leaflet-tile-container {
  pointer-events: none;
}
.leaflet-marker-icon.leaflet-interactive {
  pointer-events: visiblePainted;
  pointer-events: auto;
}
.leaflet-container {
  background: #ddd;
  outline: 0;
}
.leaflet-container a {
  color: #0078a8;
}
.leaflet-container {
  font: 12px/1.5 Helvetica Neue, Arial, Helvetica, sans-serif;
}
.leaflet-bar {
  box-shadow: 0 1px 5px rgba(0, 0, 0, 0.65);
  border-radius: 4px;
}
.leaflet-bar a,
.leaflet-bar a:hover {
  background-color: #fff;
  border-bottom: 1px solid #ccc;
  width: 26px;
  height: 26px;
  line-height: 26px;
  display: block;
  text-align: center;
  text-decoration: none;
  color: #000;
}
.leaflet-bar a {
  background-position: 50% 50%;
  background-repeat: no-repeat;
  display: block;
}
.leaflet-bar a:hover {
  background-color: #f4f4f4;
}
.leaflet-bar a:first-child {
  border-top-left-radius: 4px;
  border-top-right-radius: 4px;
}
.leaflet-bar a:last-child {
  border-bottom-left-radius: 4px;
  border-bottom-right-radius: 4px;
  border-bottom: none;
}
.leaflet-touch .leaflet-bar a {
  width: 30px;
  height: 30px;
  line-height: 30px;
}
.leaflet-touch .leaflet-bar a:first-child {
  border-top-left-radius: 2px;
  border-top-right-radius: 2px;
}
.leaflet-touch .leaflet-bar a:last-child {
  border-bottom-left-radius: 2px;
  border-bottom-right-radius: 2px;
}
.leaflet-control-zoom-in,
.leaflet-control-zoom-out {
  font: 700 18px Lucida Console, Monaco, monospace;
  text-indent: 1px;
}
.leaflet-touch .leaflet-control-zoom-in,
.leaflet-touch .leaflet-control-zoom-out {
  font-size: 22px;
}
.leaflet-touch .leaflet-bar {
  box-shadow: none;
}
.leaflet-touch .leaflet-bar {
  border: 2px solid rgba(0, 0, 0, 0.2);
  background-clip: padding-box;
}
.vue2leaflet-map {
  z-index: 0;
}
@media (max-width: 767px) {
  .map {
    padding-right: 0;
  }
}
.point-of-interest {
  color: #242424;
}
.point-of-interest .map {
  border: 2px solid hsla(0, 0%, 59.2%, 0.2);
  border-radius: 4px;
  height: 290px;
}
.point-of-interest .hotel-detail-content-title svg {
  height: 32px;
  width: 25px;
}
.hotels-detail-container {
  margin-bottom: 60px;
}
@media (max-width: 991px) {
  .hotels-detail-container {
    margin-bottom: 5px;
  }
}
.navbar[data-v-7532cfc4] {
  background-color: #ededed;
  height: 55px;
  padding-top: 15px;
}
.navbar__list[data-v-7532cfc4] {
  float: none;
  margin: 0 70px;
}
.navbar .scroll-spy-active[data-v-7532cfc4] {
  padding-bottom: 12px;
  color: #242424;
  font-weight: 700;
  border-bottom: 3px solid #ff9e00;
}
.navbar a[data-v-7532cfc4] {
  color: #979797;
  font-weight: 400;
  font-size: 15px;
}
.common-breadcrumbs[data-v-085350a8] {
  display: flex;
  list-style: none;
}
.common-breadcrumbs__breadcrumb[data-v-085350a8]:not(:last-child) {
  margin-left: 8px;
}
.common-breadcrumbs__breadcrumb--active[data-v-085350a8] {
  color: #040404;
}
.common-breadcrumbs__seperator[data-v-085350a8] {
  color: #8992ae;
}
.common-breadcrumbs__seperator[data-v-085350a8]:not(:last-child) {
  margin-left: 8px;
}
.share-button[data-v-02bb9b04] {
  display: block;
  width: 24px;
  height: 24px;
}
.share-button[data-v-02bb9b04] {
  position: relative;
  background: transparent;
  border: none;
  overflow: hidden;
}
.share-button__icon[data-v-cf14f46c] {
  display: block;
}
.share-button--whatsapp[data-v-cf14f46c] {
  color: #979797;
}
.share-button--whatsapp[data-v-cf14f46c]:focus,
.share-button--whatsapp[data-v-cf14f46c]:hover {
  color: #424242;
}
.share-button--whatsapp:focus .share-button__icon[data-v-cf14f46c],
.share-button--whatsapp:hover .share-button__icon[data-v-cf14f46c] {
  color: #28a745;
}
.share-button__icon[data-v-2bebcbbe] {
  display: block;
}
.share-button--telegram[data-v-2bebcbbe] {
  color: #979797;
}
.share-button--telegram[data-v-2bebcbbe]:focus,
.share-button--telegram[data-v-2bebcbbe]:hover {
  color: #424242;
}
.share-button--telegram:focus .share-button__icon[data-v-2bebcbbe],
.share-button--telegram:hover .share-button__icon[data-v-2bebcbbe] {
  color: #17a2b8;
}
.share-button__icon[data-v-4db20817] {
  display: block;
}
.share-button--copy-to-clipboard[data-v-4db20817] {
  color: #979797;
}
.share-button--copy-to-clipboard:hover .share-button__icon[data-v-4db20817],
.share-button--copy-to-clipboard[data-v-4db20817] :focus,
.share-button--copy-to-clipboard[data-v-4db20817]:hover {
  color: #424242;
}
.share-buttons__button[data-v-ad6ebbbc]:not(:last-child) {
  margin-right: 12px;
}
.gallery-thumbnail {
  display: flex;
  margin: 0 -5px;
}
.gallery-thumbnail > div {
  flex: 1;
  padding: 5px;
}
.hotel-detail-sticky {
  transition: top 0.5s ease;
  position: -webkit-sticky;
  position: sticky;
  top: 0;
  z-index: 1;
}
.hotel-detail-pin > svg {
  vertical-align: baseline;
  height: 15px;
}
.hv-image {
  background-size: cover;
  position: relative;
  cursor: pointer;
  padding-bottom: 77%;
  overflow: hidden;
}
.hv-image > div {
  position: absolute;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  background-color: rgba(0, 0, 0, 0.7);
  opacity: 0;
  color: #fff;
  text-align: center;
  transition: all 0.2s ease;
  vertical-align: middle;
  padding-top: 20px;
  font-size: 12px;
}
.hv-image > div:before {
  content: " ";
  display: inline-block;
  vertical-align: middle;
  height: 100%;
  width: 1px;
}
.hv-image.hovered > div,
.hv-image:hover > div {
  padding-top: 0;
  opacity: 1;
}
.hotel-detail-content-title {
  color: #242424;
  border-bottom: 4px solid #ff9e00;
  width: -webkit-max-content;
  width: -moz-max-content;
  width: max-content;
  padding-bottom: 9px;
}
.p-hotel-detail .hotel-detail-container[data-v-21eb7522] {
  padding-top: 5px;
}
.p-hotel-detail .hotel-detail-container .hotel-meta[data-v-21eb7522] {
  border-bottom: 1px solid #e0e0e0;
  padding-bottom: 15px;
}
.p-hotel-detail .hotel-detail-container .hotel-detail-title[data-v-21eb7522] {
  color: #424242;
}
.p-hotel-detail
  .hotel-detail-container
  .hotel-detail-content-title[data-v-21eb7522] {
  display: flex;
  align-items: center;
  margin: 20px 0;
  max-width: 100%;
}
.p-hotel-detail
  .hotel-detail-container
  .hotel-detail-content-title
  svg[data-v-21eb7522] {
  width: 27px;
  height: 27px;
  color: #000;
}
.p-hotel-detail
  .hotel-detail-container
  .hotel-detail-content-title
  h3[data-v-21eb7522] {
  margin: 0 10px 0 0;
}
.p-hotel-detail .hotel-detail-container .hotel-notes[data-v-21eb7522] {
  padding-top: 45px;
  color: #242424;
  font-size: 15px;
}
.p-hotel-detail
  .hotel-detail-container
  .hotel-notes[data-v-21eb7522]:last-child {
  padding-bottom: 45px;
}
@media (min-width: 992px) {
  .p-hotel-detail .hotel-detail-container[data-v-21eb7522] {
    padding-top: 11px;
  }
  .p-hotel-detail .hotel-detail-container .hotel-meta[data-v-21eb7522] {
    border-bottom: none;
    padding: 13px 0 12px;
  }
  .p-hotel-detail .hotel-detail-container .hotel-detail-title[data-v-21eb7522] {
    margin: 0;
  }
  .p-hotel-detail
    .hotel-detail-container
    .hotel-detail-content[data-v-21eb7522] {
    margin-top: 40px;
    overflow: hidden;
  }
  .p-hotel-detail
    .hotel-detail-container
    .hotel-detail-gallery[data-v-21eb7522] {
    min-height: 470px;
  }
}
/*! Embedded */
.vue2leaflet-map {
  height: 100%;
  width: 100%;
}
/*! https://cdn.alibaba.ir/dist/ff4aed11/1b08b6349f5ed1f12e54.css */
.calendar[data-v-6b378218] {
  max-width: 340px;
}
.calendar > h4[data-v-6b378218] {
  font-size: 13px;
  text-align: center;
  font-weight: 400;
}
.calendar__weekdays[data-v-6b378218] {
  display: flex;
  padding: 10px 0;
  font-size: 0.8em;
}
.calendar__weekdays > span[data-v-6b378218] {
  flex: 1;
  text-align: center;
}
.calendar__container[data-v-6b378218] {
  display: flex;
  flex-wrap: wrap;
}
.calendar__day[data-v-6b378218] {
  flex: 14.28571% 0 1;
  font-size: 15px;
  cursor: pointer;
  border: 1px solid transparent;
  background-color: transparent;
  margin: 2px 0;
  color: #616161;
  font-weight: 400;
}
.calendar__day[data-v-6b378218],
.calendar__day__content[data-v-6b378218] {
  display: flex;
  align-items: center;
  justify-content: center;
  position: relative;
}
.calendar__day__content[data-v-6b378218] {
  z-index: 5;
  width: 100%;
  height: 100%;
}
.calendar__day__square[data-v-6b378218] {
  content: " ";
  display: block;
  padding-bottom: 100%;
}
.calendar__day.holiday[data-v-6b378218] {
  color: #f32415;
}
.calendar__day[data-v-6b378218]:active:after,
.calendar__day[data-v-6b378218]:hover:after {
  content: " ";
  display: block;
  position: absolute;
  top: -1px;
  left: -1px;
  right: -1px;
  bottom: -1px;
  border: 2px solid #ffbe47;
  border-radius: 4px;
  z-index: 3;
  transition: background-color 0.12s linear;
  background-color: #fff;
}
@media (max-width: 767px) {
  .calendar__day[data-v-6b378218]:hover:after {
    border-color: transparent;
  }
}
.calendar__day[data-v-6b378218]:active:after {
  background-color: #cc8400;
}
.calendar__day.before[data-v-6b378218] {
  opacity: 0.44;
  cursor: default;
  border-color: transparent;
  background-color: transparent;
}
.calendar__day.before[data-v-6b378218]:after {
  content: none;
  display: none;
}
.calendar__day .btn-today[data-v-6b378218] {
  position: absolute;
  top: 0;
  right: 0;
  left: 0;
  bottom: 0;
}
.btn-today {
  border: 1px dotted #e1e1e1;
  position: relative;
  border-radius: 4px;
}
.btn-today:before {
  content: " ";
  display: block;
  position: absolute;
  top: -6px;
  right: -6px;
  border: 6px solid transparent;
  border-bottom-color: inherit;
  transform: rotate(45deg);
}
.alibaba-datepicker[data-v-65b601f8] {
  z-index: auto;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
}
@media (min-width: 768px) {
  .alibaba-datepicker[data-v-65b601f8] {
    position: relative;
  }
}
@media (max-width: 767px) {
  .alibaba-datepicker__wrapper[data-v-65b601f8] {
    -webkit-animation-name: fadeIn-data-v-65b601f8;
    animation-name: fadeIn-data-v-65b601f8;
    -webkit-animation-iteration-count: 1s;
    animation-iteration-count: 1s;
    -webkit-animation-duration: 0.25s;
    animation-duration: 0.25s;
    -webkit-animation-delay: 0s;
    animation-delay: 0s;
    -webkit-animation-timing-function: ease;
    animation-timing-function: ease;
    -webkit-animation-fill-mode: both;
    animation-fill-mode: both;
    -webkit-backface-visibility: hidden;
    backface-visibility: hidden;
  }
}
.alibaba-datepicker__wrapper[data-v-65b601f8] {
  position: fixed;
  top: 0;
  left: 0;
  height: 100%;
  width: 100%;
  background-color: #fff;
  overflow: auto;
  z-index: 5000;
}
.alibaba-datepicker__wrapper > div[data-v-65b601f8] {
  padding: 95px 10px 40px;
}
@media (min-width: 370px) {
  .alibaba-datepicker__wrapper[data-v-65b601f8] {
    width: auto;
    height: auto;
    right: 10px;
    left: 10px;
    top: 10px;
    bottom: 10px;
  }
}
@media (min-width: 768px) {
  .alibaba-datepicker__wrapper[data-v-65b601f8] {
    position: absolute;
    padding: 15px 15px 10px;
    top: 100%;
    right: 50%;
    transform: translateX(50%);
    margin-top: 5px;
    width: 550px;
    height: auto;
    bottom: auto;
    overflow: hidden;
  }
  .alibaba-datepicker__wrapper.left[data-v-65b601f8] {
    transform: none;
    left: 0;
    right: auto;
  }
  .alibaba-datepicker__wrapper > div[data-v-65b601f8] {
    padding: 0;
  }
}
.alibaba-datepicker__container[data-v-65b601f8] {
  display: flex;
  flex-wrap: wrap;
  justify-content: flex-start;
  position: absolute;
  top: 100px;
  left: 0;
  right: 0;
  bottom: 105px;
  overflow: auto;
  padding: 10px;
}
.alibaba-datepicker__container.slide-left[data-v-65b601f8] {
  justify-content: flex-end;
}
.alibaba-datepicker__container > div[data-v-65b601f8] {
  flex: 100% 1 1;
  transition: transform 0.16s linear;
  position: relative;
}
.alibaba-datepicker__container > div[data-v-65b601f8]:not(:last-child):after {
  content: " ";
  position: absolute;
  display: block;
  background-color: #f1f6f8;
  bottom: 0;
  left: 0;
  right: 0;
  height: 1px;
}
@media (min-width: 768px) {
  .alibaba-datepicker__container > div[data-v-65b601f8]:not(:last-child):after {
    top: 40px;
    bottom: 10px;
    width: 1px;
    right: auto;
    height: auto;
  }
}
@media (min-width: 768px) {
  .alibaba-datepicker__container[data-v-65b601f8] {
    position: static;
    overflow: hidden;
    flex-wrap: nowrap;
    padding: 0;
    margin: 0 -10px;
  }
  .alibaba-datepicker__container > div[data-v-65b601f8] {
    flex: 50% 0 0;
  }
}
.alibaba-datepicker__arrows[data-v-65b601f8] {
  position: absolute;
  left: 0;
  right: 0;
  display: flex;
  z-index: 8;
  justify-content: space-between;
  padding: 0 15px;
}
.alibaba-datepicker__arrows > button[data-v-65b601f8] {
  display: inline-block;
  color: #979797;
  background-color: #f7f7f7;
  border: 1px solid #f1f6f8;
  padding: 7px;
  border-radius: 4px;
}
.alibaba-datepicker__arrows > button[data-v-65b601f8]:disabled {
  cursor: not-allowed;
}
.alibaba-datepicker__header[data-v-65b601f8] {
  position: absolute;
  top: 0;
  left: 0;
  right: 0;
  z-index: 12;
  font-family: IranSans, Tahoma, serif;
}
.alibaba-datepicker__header > div[data-v-65b601f8] {
  display: flex;
  position: relative;
  z-index: 14;
  align-items: center;
}
.alibaba-datepicker__header > div > button[data-v-65b601f8],
.alibaba-datepicker__header > div > span[data-v-65b601f8] {
  flex: 1;
}
.alibaba-datepicker__header .close[data-v-65b601f8] {
  font-size: 32px;
  padding: 12px;
  opacity: 1;
  color: orange;
  position: static;
}
.alibaba-datepicker__header .btn[data-v-65b601f8] {
  padding: 0 12px;
}
.alibaba-datepicker__header .btn.active[data-v-65b601f8] {
  font-weight: 500;
  color: #2979ff;
  outline: none;
  box-shadow: none;
}
@media (min-width: 768px) {
  .alibaba-datepicker__header[data-v-65b601f8] {
    position: static;
    border-bottom: 1px solid #f1f6f8;
    margin-top: -5px;
    margin-bottom: 15px;
    padding-bottom: 8px;
    font-size: 13px;
  }
}
.alibaba-datepicker .btn[data-v-65b601f8] {
  font-size: inherit;
}
.alibaba-datepicker__footer[data-v-65b601f8] {
  position: absolute;
  bottom: 0;
  left: 0;
  right: 0;
  background-color: #fff;
  padding: 10px;
  z-index: 12;
  box-shadow: 0 -15px 35px rgba(0, 0, 0, 0.06);
  font-family: IranSans, Tahoma, serif;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  align-items: stretch;
  font-size: 13px;
}
.alibaba-datepicker__footer .btn[data-v-65b601f8] {
  font-size: 1.23em;
}
@media (min-width: 768px) {
  .alibaba-datepicker__footer[data-v-65b601f8] {
    flex-direction: row;
    align-items: center;
    position: static;
    padding: 0;
    box-shadow: none;
  }
  .alibaba-datepicker__footer .btn[data-v-65b601f8] {
    font-size: 1em;
  }
}
.alibaba-datepicker hr[data-v-65b601f8] {
  border-color: #f1f6f8;
}
/*! https://cdn.alibaba.ir/dist/ff4aed11/54987925bd5a35c4a38b.css */
.search-passengers-room[data-v-7c07d2e0] {
  padding: 0 0 20px;
}
.v-dropdown[data-v-428b9aff] {
  min-width: 320px;
  margin-top: 5px;
}
@media (min-width: 992px) {
  .v-dropdown[data-v-428b9aff] {
    right: auto;
    left: 0;
  }
}
.v-dropdown[data-v-428b9aff]:before {
  content: "";
  display: block;
  width: 0;
  height: 0;
  border: 5px solid transparent;
  border-bottom-color: #fff;
  position: absolute;
  top: -10px;
  left: 10px;
  z-index: 21;
}
@media (min-width: 1200px) {
  .v-dropdown[data-v-428b9aff]:before {
    right: 145px;
    left: auto;
  }
}
.passenger-picker-dropdown[data-v-428b9aff] {
  overflow-x: hidden;
  overflow-y: auto;
  max-height: 35vh;
}
/*! https://cdn.alibaba.ir/dist/ff4aed11/ff88210f8ebba794a366.css */
.rate-stars[data-v-02a24b22] {
  font-size: 0.7em;
  color: #aaa;
  display: inline-block;
}
.rate-stars .icon-star-rate[data-v-02a24b22] {
  color: #d2d2d2;
  padding: 0 2.5px;
}
.rate-stars .icon-star-rate.active[data-v-02a24b22] {
  color: #ffc800;
}
/*! https://cdn.alibaba.ir/dist/ff4aed11/b05996f33dc22a13c9c7.css */
.leaflet-layer,
.leaflet-marker-icon,
.leaflet-pane,
.leaflet-tile,
.leaflet-tile-container {
  position: absolute;
  left: 0;
  top: 0;
}
.leaflet-container {
  overflow: hidden;
}
.leaflet-marker-icon,
.leaflet-tile {
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
  -webkit-user-drag: none;
}
.leaflet-marker-icon {
  display: block;
}
.leaflet-container .leaflet-marker-pane img,
.leaflet-container .leaflet-tile,
.leaflet-container .leaflet-tile-pane img {
  max-width: none !important;
  max-height: none !important;
}
.leaflet-container.leaflet-touch-zoom {
  touch-action: pan-x pan-y;
}
.leaflet-container.leaflet-touch-drag {
  touch-action: none;
  touch-action: pinch-zoom;
}
.leaflet-container.leaflet-touch-drag.leaflet-touch-zoom {
  touch-action: none;
}
.leaflet-container {
  -webkit-tap-highlight-color: transparent;
}
.leaflet-container a {
  -webkit-tap-highlight-color: rgba(51, 181, 229, 0.4);
}
.leaflet-tile {
  -webkit-filter: inherit;
  filter: inherit;
  visibility: hidden;
}
.leaflet-tile-loaded {
  visibility: inherit;
}
.leaflet-pane {
  z-index: 400;
}
.leaflet-tile-pane {
  z-index: 200;
}
.leaflet-overlay-pane {
  z-index: 400;
}
.leaflet-shadow-pane {
  z-index: 500;
}
.leaflet-marker-pane {
  z-index: 600;
}
.leaflet-tooltip-pane {
  z-index: 650;
}
.leaflet-popup-pane {
  z-index: 700;
}
.leaflet-control {
  position: relative;
  z-index: 800;
  pointer-events: visiblePainted;
  pointer-events: auto;
}
.leaflet-bottom,
.leaflet-top {
  position: absolute;
  z-index: 1000;
  pointer-events: none;
}
.leaflet-top {
  top: 0;
}
.leaflet-right {
  right: 0;
}
.leaflet-bottom {
  bottom: 0;
}
.leaflet-left {
  left: 0;
}
.leaflet-control {
  float: left;
  clear: both;
}
.leaflet-top .leaflet-control {
  margin-top: 10px;
}
.leaflet-left .leaflet-control {
  margin-left: 10px;
}
.leaflet-fade-anim .leaflet-tile {
  will-change: opacity;
}
.leaflet-zoom-animated {
  transform-origin: 0 0;
}
.leaflet-interactive {
  cursor: pointer;
}
.leaflet-grab {
  cursor: -webkit-grab;
  cursor: grab;
}
.leaflet-control,
.leaflet-popup-pane {
  cursor: auto;
}
.leaflet-marker-icon,
.leaflet-tile-container {
  pointer-events: none;
}
.leaflet-marker-icon.leaflet-interactive {
  pointer-events: visiblePainted;
  pointer-events: auto;
}
.leaflet-container {
  background: #ddd;
  outline: 0;
}
.leaflet-container a {
  color: #0078a8;
}
.leaflet-container {
  font: 12px/1.5 Helvetica Neue, Arial, Helvetica, sans-serif;
}
.leaflet-bar {
  box-shadow: 0 1px 5px rgba(0, 0, 0, 0.65);
  border-radius: 4px;
}
.leaflet-bar a,
.leaflet-bar a:hover {
  background-color: #fff;
  border-bottom: 1px solid #ccc;
  width: 26px;
  height: 26px;
  line-height: 26px;
  display: block;
  text-align: center;
  text-decoration: none;
  color: #000;
}
.leaflet-bar a {
  background-position: 50% 50%;
  background-repeat: no-repeat;
  display: block;
}
.leaflet-bar a:hover {
  background-color: #f4f4f4;
}
.leaflet-bar a:first-child {
  border-top-left-radius: 4px;
  border-top-right-radius: 4px;
}
.leaflet-bar a:last-child {
  border-bottom-left-radius: 4px;
  border-bottom-right-radius: 4px;
  border-bottom: none;
}
.leaflet-touch .leaflet-bar a {
  width: 30px;
  height: 30px;
  line-height: 30px;
}
.leaflet-touch .leaflet-bar a:first-child {
  border-top-left-radius: 2px;
  border-top-right-radius: 2px;
}
.leaflet-touch .leaflet-bar a:last-child {
  border-bottom-left-radius: 2px;
  border-bottom-right-radius: 2px;
}
.leaflet-control-zoom-in,
.leaflet-control-zoom-out {
  font: 700 18px Lucida Console, Monaco, monospace;
  text-indent: 1px;
}
.leaflet-touch .leaflet-control-zoom-in,
.leaflet-touch .leaflet-control-zoom-out {
  font-size: 22px;
}
.leaflet-touch .leaflet-bar {
  box-shadow: none;
}
.leaflet-touch .leaflet-bar {
  border: 2px solid rgba(0, 0, 0, 0.2);
  background-clip: padding-box;
}
/*! https://cdn.alibaba.ir/dist/ff4aed11/73476465eeb3d569d1ee.css */
.search-passengers-room[data-v-7c07d2e0] {
  padding: 0 0 20px;
}
.v-dropdown[data-v-428b9aff] {
  min-width: 320px;
  margin-top: 5px;
}
@media (min-width: 992px) {
  .v-dropdown[data-v-428b9aff] {
    right: auto;
    left: 0;
  }
}
.v-dropdown[data-v-428b9aff]:before {
  content: "";
  display: block;
  width: 0;
  height: 0;
  border: 5px solid transparent;
  border-bottom-color: #fff;
  position: absolute;
  top: -10px;
  left: 10px;
  z-index: 21;
}
@media (min-width: 1200px) {
  .v-dropdown[data-v-428b9aff]:before {
    right: 145px;
    left: auto;
  }
}
.passenger-picker-dropdown[data-v-428b9aff] {
  overflow-x: hidden;
  overflow-y: auto;
  max-height: 35vh;
}
.rate-stars[data-v-02a24b22] {
  font-size: 0.7em;
  color: #aaa;
  display: inline-block;
}
.rate-stars .icon-star-rate[data-v-02a24b22] {
  color: #d2d2d2;
  padding: 0 2.5px;
}
.rate-stars .icon-star-rate.active[data-v-02a24b22] {
  color: #ffc800;
}
.common-breadcrumbs[data-v-085350a8] {
  display: flex;
  list-style: none;
}
.common-breadcrumbs__breadcrumb[data-v-085350a8]:not(:last-child) {
  margin-left: 8px;
}
.common-breadcrumbs__breadcrumb--active[data-v-085350a8] {
  color: #040404;
}
.common-breadcrumbs__seperator[data-v-085350a8] {
  color: #8992ae;
}
.common-breadcrumbs__seperator[data-v-085350a8]:not(:last-child) {
  margin-left: 8px;
}
/*! CSS Used keyframes */
@-webkit-keyframes fadeIn {
  0% {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
@keyframes fadeIn {
  0% {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
@-webkit-keyframes fadeIn {
  0% {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
@keyframes fadeIn {
  0% {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
@-webkit-keyframes fadeIn {
  0% {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
@keyframes fadeIn {
  0% {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
@-webkit-keyframes fadeIn {
  0% {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
@keyframes fadeIn {
  0% {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
@-webkit-keyframes fadeIn-data-v-65b601f8 {
  0% {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
@keyframes fadeIn-data-v-65b601f8 {
  0% {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
@-webkit-keyframes fadeIn-data-v-65b601f8 {
  0% {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
@keyframes fadeIn-data-v-65b601f8 {
  0% {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
</style>