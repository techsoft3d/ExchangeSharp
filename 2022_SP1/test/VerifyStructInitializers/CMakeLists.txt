cmake_minimum_required(VERSION 3.0.0)
project(VerifyStructInitializers VERSION 0.1.0)

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED True)
add_library(verify_initializers SHARED 
    verify_initializers.cpp)
set_target_properties(verify_initializers PROPERTIES PREFIX "" OUTPUT_NAME "VerifyInitializers" SUFFIX ".test")
set(HOOPS_EXCHANGE_DIR "C:\\work\\Exchange\\HOOPS_Exchange_Publish_2022_SP1")
target_include_directories(verify_initializers PUBLIC "${HOOPS_EXCHANGE_DIR}/include")


