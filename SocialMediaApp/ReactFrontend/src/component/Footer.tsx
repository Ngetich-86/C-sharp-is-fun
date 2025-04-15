
import { FaFacebookF, FaLinkedinIn, FaInstagram } from 'react-icons/fa';

const Footer = () => {
  return (
    <footer className="bg-black text-gray-400 py-8">
      <div className="container mx-auto px-6 md:px-12 lg:px-24 flex items-center justify-between">
        {/* Left Section - Brand Name */}
        <div className="text-lg font-semibold">Viralink Media</div>

        {/* Middle Section - Copyright */}
        <div className="text-sm">Copyright © Viralink Media 2025. All rights reserved.</div>

        {/* Right Section - Social Media Icons */}
        <div className="flex space-x-4">
          <a href="#" className="hover:text-white transition duration-300">
            <FaFacebookF size={20} />
          </a>
          <a href="#" className="hover:text-white transition duration-300">
            <FaLinkedinIn size={20} />
          </a>
          <a href="#" className="hover:text-white transition duration-300">
            <FaInstagram size={20} />
          </a>
        </div>
      </div>
    </footer>
  );
};

export default Footer;