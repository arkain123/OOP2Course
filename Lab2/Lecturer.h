#pragma once
#include <string>
#include "Course.h"


class Lecturer {
private:
    std::string name;

public:
    Lecturer(std::string lecturer_name) : name(lecturer_name) {}

    void announce_course(Course& Course);
    void give_mark(std::string student_name, int mark);
};