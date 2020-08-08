<template>
  <div>
    <main class="bg-gray main-wrapper">
      <div class="container">
        <div class="profile-login">
          <div class="box">
            <div class="row profile-login__container">
              <div class>
                <div class="box-login-type text-center mb-3">
                  <h3>تغییر اطلاعات کاربری</h3>
                </div>
                <form
                   @submit.prevent="update"
                  method="post"
                  novalidate="novalidate"
                  autocomplete="off"
                  class="validated-form signup-form"
                >
                  <div>
                    <div class="col-xs-12 col-sm-6">
                      <div class="form-group">
                        <label for="email">
                          ایمیل
                          (الزامی)
                        </label>
                        <input
                          type="email"
                          v-model="user.Email"
                          dir="ltr"
                          id="email"
                          name="email"
                          autofocus="autofocus"
                          class="form-control"
                        />
                        <!---->
                      </div>
                    </div>
                    <div class="col-xs-12 col-sm-6">
                      <div class="form-group">
                        <label for="phone">
                          تلفن همراه
                          (الزامی)
                        </label>
                        <input type="tel"
                          v-model="user.Mobile" dir="ltr" id="phone" name="phone" class="form-control" />
                        <!---->
                      </div>
                    </div>
                    <div class="col-xs-12 col-sm-6">
                      <div class="form-group">
                        <label for="password">
                          رمز عبور
                          (الزامی)
                        </label>
                        <input
                          type="password"                          
                          v-model="user.Password"
                          dir="ltr"
                          id="password"
                          name="password"
                          class="form-control"
                        />
                        <!---->
                      </div>
                    </div>
                    <div class="col-xs-12 col-sm-6">
                      <div class="form-group">
                        <label for="confirm-password">
                          تکرار رمز
                          عبور
                        </label>
                        <input
                          type="password"
                          dir="ltr"
                          id="confirm-password"
                          name="confirm-password"
                          class="form-control"
                        />
                        <!---->
                      </div>
                    </div>
                    <button
                      type="submit"
                      id="signup-action-btn"
                      class="btn btn-block btn-primary login-form-submit"
                    >
                      ثبت تغییرات
                      <span class="dots" style="display: none;">...</span>
                    </button>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
      </div>
    </main>
    <main class="bg-gray main-wrapper" v-if="hm">
      <div class="container">
        <div class="profile-login">
          <div class="box" style="padding-top: 0px !important;margin-top: 0px !important;">
            <div class="row profile-login__container">
              <div class>
                <div class="box-login-type text-center mb-3">
                  <h3>ثبت اطلاعات یک هتل جدید</h3>
                </div>
                <form
                   @submit.prevent="newhotel"
                  method="post"
                  novalidate="novalidate"
                  autocomplete="off"
                  class="validated-form signup-form"
                >
                  <div>
                    <div class="col-xs-12 col-sm-6">
                      <div class="form-group">
                        <label for="email">
                          نام هتل
                          (الزامی)
                        </label>
                        <input
                          type="email"
                          v-model="hotel.Name"
                          dir="ltr"
                          id="email"
                          name="email"
                          autofocus="autofocus"
                          class="form-control"
                        />
                        <!---->
                      </div>
                    </div>
                    <div class="col-xs-12 col-sm-6">
                      <div class="form-group">
                        <label for="phone">
                          شهر هتل
                          (الزامی)
                        </label>
                        <input type="tel"
                          v-model="hotel.City" dir="ltr" id="phone" name="phone" class="form-control" />
                        <!---->
                      </div>
                    </div>
                    <div class="col-xs-12 col-sm-6">
                      <div class="form-group">
                        <label for="password">
                          آدرس هتل
                          (الزامی)
                        </label>
                        <input
                          type=""
                          dir="ltr"
                          v-model="hotel.Address"
                          id="password"
                          name="password"
                          class="form-control"
                        />
                        <!---->
                      </div>
                    </div>
                    <div class="col-xs-12 col-sm-6">
                      <div class="form-group">
                        <label for="confirm-password">آدرس لوکیشن گوگل مپ هتل</label>
                        <input
                          type=""
                          v-model="hotel.Location"
                          dir="ltr"
                          id="confirm-password"
                          name="confirm-password"
                          class="form-control"
                        />
                        <!---->
                      </div>
                    </div>
                    <div class="col-xs-12 col-sm-12">
                      <div class="form-group">
                        <label for="confirm-password">عکس های هتل</label>
                        <input type="file" dir="ltr" multiple class="form-control" />
                        <!---->
                      </div>
                    </div>
                    <div class="col-xs-6 col-sm-6">
                      <div class="form-group">
                        <label for="email">
                          آدرس عکس                        </label>
                        <input
                          type="email"                          
                          v-model="Pic.Url"
                          dir="ltr"
                          id="email"
                          name="email"
                          autofocus="autofocus"
                          class="form-control"
                        />
                        <!---->
                      </div>
                    </div>
                    <div class="col-xs-6 col-sm-3">
                      <div class="form-group">
                        <label for="phone">
                          توضیجات عکس                        </label>
                        <input type="tel"                          
                          v-model="Pic.Description" dir="ltr" id="phone" name="phone" class="form-control" />
                        <!---->
                      </div>
                    </div>
                    <button
                      class="col-xs-6 col-sm-3 btn"
                      
                      style="margin-top: 30px;"
                    >اضافه کردن</button>

                    <hr />
                    <div class="col-xs-12 col-sm-12 text-center" style="margin-top:15px">
                      <p>امکانات هتل</p>
                    </div>
                    <div class="col-xs-6 col-sm-3">
                      <div class="form-group">
                        <label for="email">
                          نام ویژگی
                          (الزامی)
                        </label>
                        <input
                          type="email"
                          dir="ltr"                        
                          v-model="Feature.Name"
                          id="email"
                          name="email"
                          autofocus="autofocus"
                          class="form-control"
                        />
                        <!---->
                      </div>
                    </div>
                    <div class="col-xs-6 col-sm-3">
                      <div class="form-group">
                        <label for="phone">
                          مقدار ویژگی
                          (الزامی)
                        </label>
                        <input type="tel"                        
                          v-model="Feature.Value" dir="ltr" id="phone" name="phone" class="form-control" />
                        <!---->
                      </div>
                    </div>
                    <button
                      class="col-xs-6 col-sm-6 btn"
                      
                      style="margin-top: 30px;"
                    >اضافه کردن</button>

                    <hr />
                    <div class="col-xs-12 col-sm-12 text-center" style="margin-top:15px">
                      <p>اتاق های هتل</p>
                    </div>
                    <div class="col-xs-6 col-sm-3">
                      <div class="form-group">
                        <label for="email">
                          نام اتاق
                          (الزامی)
                        </label>
                        <input
                          type="email"
                          dir="ltr"                        
                          v-model="Room.Name"
                          id="email"
                          name="email"
                          autofocus="autofocus"
                          class="form-control"
                        />
                        <!---->
                      </div>
                    </div>
                    <div class="col-xs-6 col-sm-2">
                      <div class="form-group">
                        <label for="phone">حداکثر بزرگسال</label>
                        <input type="number"                        
                          v-model="Room.Adult" dir="ltr" id="phone" name="phone" class="form-control" />
                        <!---->
                      </div>
                    </div>
                    <div class="col-xs-6 col-sm-2">
                      <div class="form-group">
                        <label for="phone">حداکثر کودک</label>
                        <input type="number"                        
                          v-model="Room.Kid" dir="ltr" id="phone" name="phone" class="form-control" />
                        <!---->
                      </div>
                    </div>
                    <div class="col-xs-6 col-sm-2">
                      <div class="form-group">
                        <label for="phone">صبحانه</label>
                        <input
                          type="checkbox"
                          dir="ltr"                        
                          v-model="Room.Breakfast"
                          id="phone"
                          name="phone"
                          class="form-control"
                        />
                        <!---->
                      </div>
                    </div>
                    <button class="btn" style="margin-top: 30px;">اضافه کردن اتاق</button>

                    <button
                      type="submit"
                      style="margin-top: 50px;"
                      id="signup-action-btn"
                      class="btn btn-block btn-primary login-form-submit"
                    >
                      ارسال
                      <span class="dots" style="display: none;">...</span>
                    </button>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
      </div>
    </main>
  </div>
</template>

<script>
const Cookie = process.client ? require("js-cookie") : undefined;

export default {
    
  data() {
    return {
      form: "login",
      hm:true,
      hotel:{     
        HotelManagerId:1, 
        Location: "",
        Address: "",
        City: "",
        Name: "",
        Feature: [],
        Room: [],
        Pic: []
      },      
      user:{     
        Id:1, 
        Email: "",
        Mobile: "",
        Password: ""
      },
      Pic:{
          Url:"",
          Description:"",
          HotelId:1
      },Feature:{
          Name:"",
          Value:"",
          HotelId:1
      },Room:{
          Name:"",
          Adult:"",
          Kid:"",
          Breakfast:false,
          HotelId:1
      }
    };
  },
  methods: {
    addf() {

    },
    addr() {},
    async newhotel(name) {
        this.hotel.Pic.push(this.Pic)
        this.hotel.Room.push(this.Room)
        this.hotel.Feature.push(this.Feature)
      await this.$axios({
        method: "post",
        url: 'hotels',
        data: this.hotel
      })
        .then((data) => {      
         this.$toast.success("Successful Added");
        })
        .catch((e) => {
            console.log(e)
            this.$toast.error(e);
        });
    },
    async update(name) {
      await this.$axios({
        method: "put",
        url: 'users'+'/'+this.user.Id,
        data: this.user
      })
        .then((data) => {      
         this.$toast.success("Successful Updated");
        })
        .catch((e) => {
            console.log(e)
            this.$toast.error(e);
        });
    }
  },
  mounted(){
        if(Cookie.getJSON('auth') === undefined){
            this.$router.push("/");
        }else{
            this.hotel.HotelManagerId = this.user.Id = this.Room.HotelId = this.Feature.HotelId = this.Pic.HotelId = Cookie.get('auth')
            // this.user.Id = Cookie.get('auth')
            this.hm=Cookie.get('hm')
        }
    }
};
</script>