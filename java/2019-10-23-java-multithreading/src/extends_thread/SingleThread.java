package extends_thread;

public class SingleThread {

    public static void main(String[] args) throws InterruptedException {
        ThreadDemo T1 = new ThreadDemo("Thread-1");
        T1.start();

        ThreadDemo T2 = new ThreadDemo("Thread-2");
        T2.start();
    }
}
