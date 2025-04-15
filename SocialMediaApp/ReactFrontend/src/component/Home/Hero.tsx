

const Hero = () => {
  return (
    <section className="bg-black text-white py-24 md:py-36 lg:py-48">
      <div className="container mx-auto px-6 md:px-12 lg:px-24 flex flex-col lg:flex-row items-center justify-between">
        {/* Left Column - Text Content */}
        <div className="lg:w-1/2 text-center lg:text-left mb-12 lg:mb-0">
          <h1 className="text-4xl md:text-5xl lg:text-6xl font-bold mb-4">
            Going viral <span className="text-red-500">—</span>
          </h1>
          <h2 className="text-2xl md:text-3xl lg:text-4xl font-semibold mb-6">
            one post at a time.
          </h2>
          <p className="text-lg md:text-xl text-gray-300 mb-8">
            Your personal social media team of creatives that work to grow your
            audience and generate real traffic!
          </p>
          <button className="bg-red-500 hover:bg-red-600 text-white font-bold py-3 px-6 rounded-md">
            Get In Touch
          </button>
        </div>

        {/* Right Column - Image/Mockup */}
        <div className="lg:w-1/2 flex justify-center relative">
          {/* Background Gradient */}
          <div className="absolute inset-0 bg-gradient-to-br from-gray-900 to-black opacity-50 rounded-lg"></div>

          {/* Phone Mockups */}
          <div className="relative z-10 flex items-center justify-center">
            <div className="relative w-40 h-80 md:w-48 md:h-96">
              <div className="absolute inset-0 bg-gray-800 rounded-xl shadow-lg transform rotate-6">
                {/* Replace with your actual phone screen image */}
                <img
                  src="https://cdn.pixabay.com/photo/2017/08/01/09/07/mobile-2563782_1280.jpg"
                  alt="Phone Screen 1"
                  className="absolute inset-0 w-full h-full object-cover rounded-xl"
                />
              </div>
            </div>
            <div className="relative w-40 h-80 md:w-48 md:h-96 ml-8">
              <div className="absolute inset-0 bg-gray-800 rounded-xl shadow-lg transform -rotate-6">
                {/* Replace with your actual phone screen image */}
                <div className="absolute inset-0 flex items-center justify-center">
                  <div className="relative w-12 h-12">
                    <div className="absolute inset-0 border-2 border-white rounded-sm"></div>
                    <div className="absolute inset-0 flex items-center justify-center text-xl font-bold">V</div>
                    <div className="absolute top-1 left-1 w-1 h-1 bg-red-500 rounded-full"></div>
                  </div>
                </div>
                <img
                  src="https://cdn.pixabay.com/photo/2017/11/06/08/42/personal-2923048_1280.jpg"
                  alt="Phone Screen 2"
                  className="absolute inset-0 w-full h-full object-cover rounded-xl opacity-30"
                />
              </div>
            </div>
          </div>
        </div>
      </div>

      {/* Bottom Section - Brand Names */}
      <div className="container mx-auto px-6 md:px-12 lg:px-24 py-12 flex justify-center space-x-16 text-3xl font-bold text-gray-400">
        <span>Viralink</span>
        <span>Media</span>
      </div>
    </section>
  );
};

export default Hero;