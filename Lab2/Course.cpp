#include "Course.h"


void Course::join_course(std::string student_name) {
    students.push_back(student_name);
}

void Course::educate(std::string student_name) {
    // Здесь может быть реализация обучения студента на курсе.
}

void Course::give_mark(std::string student_name, int mark) {
    marks[student_name] = mark;
}