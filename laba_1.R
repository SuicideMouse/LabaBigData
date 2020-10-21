print("hello world")
str <- "hello world"
print(str)
a <- 13
print(a)
b <- 2
print(b)
c <- 1.5
print(c)
#########
print(a/b)
print(a*b)
print(a-b)
print(a+b)
#########
if (a<b) {
  print(TRUE)
}else{
  print(FALSE)
}
#########
v <- c( 2,5.5,6)
t <- c(8, 3, 4)
print(v+t)
#########
new.function <- function(a) {
  for(i in 1:a) {
    b <- i^2
    print(b)
  }
}
new.function(6)
#########
vec <- c(2,3,6)
vec1 <- c(2,11,8)
print(vec)
print(vec + vec1)
#######
list_data <- list("Red", "Green", c(21,32,11), TRUE, 51.23, 119.1)
print(list_data)
#######
M <- matrix(c(1:16), nrow = 4, ncol = 4)
print(M)
#######
my.array <- array(c(1,2,3,4), dim =c(2,2))
print(my.array)
#######
x <- c(21, 62, 10, 53)
labels <- c("x", "y", "z", "k")
pie(x,labels)
