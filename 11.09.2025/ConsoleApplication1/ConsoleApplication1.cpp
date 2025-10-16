#include <iostream>
#include <iomanip>  // dla setw()

int main() {
    // Nagłówki
    std::cout << std::setw(10) << "ID"
        << std::setw(15) << "Imię"
        << std::setw(15) << "Nazwisko" << std::endl;

    // Linia oddzielająca
    std::cout << std::string(40, '-') << std::endl;

    // Dane
    std::cout << std::setw(10) << 1
        << std::setw(15) << "Jan"
        << std::setw(15) << "Kowalski" << std::endl;

    std::cout << std::setw(10) << 2
        << std::setw(15) << "Anna"
        << std::setw(15) << "Nowak" << std::endl;

    return 0;
}