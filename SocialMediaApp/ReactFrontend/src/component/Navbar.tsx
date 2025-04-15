
const Navbar = () => {
  return (
    <nav className="bg-black text-white py-4 flex items-center justify-between px-6">
      {/* Logo Section */}
      <div className="flex items-center">
        <div className="relative w-8 h-8">
          <div className="absolute inset-0 border-2 border-white"></div>
          <div className="absolute inset-0 flex items-center justify-center text-xl font-bold">S</div>
          <div className="absolute top-1 left-1 w-1 h-1 bg-red-500 rounded-full"></div>
        </div>
      </div>

      {/* Navigation Links Section */}
      <div className="space-x-6">
        <a href="#" className="hover:text-gray-300">Home</a>
        <a href="#" className="hover:text-gray-300">Services</a>
        <a href="#" className="hover:text-gray-300">Contact Us</a>
      </div>
    </nav>
  );
};

export default Navbar;