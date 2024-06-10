#include "Faculty.h"


int main() {

    Lecturer Lecturer1("Иванов");
    Lecturer Lecturer2("Петров");

    Course Course1("Математика");
    Course Course2("Литература");

    Lecturer1.announce_course(Course1);
    Lecturer2.announce_course(Course2);

    Course1.join_course("Алексей");
    Course2.join_course("Екатерина");

    Course1.educate("Алексей");
    Course2.educate("Екатерина");

    Course1.give_mark("Алексей", 5);
    Course2.give_mark("Екатерина", 4);

    Lecturer1.give_mark("Алексей", 5);
    Lecturer2.give_mark("Екатерина", 4);

    return 0;
}