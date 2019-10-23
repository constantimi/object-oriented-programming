package implements_thread;

public class RunnableDemo implements Runnable{
    private Thread thread;
    private String threadName;

    public RunnableDemo(String name) {
        threadName = name;
        System.out.println("Creating " + threadName);
    }

    @Override
    public void run(){
        System.out.println("Running " + threadName);

        try {
            for (int i = 0; i < 10; i++) {
                System.out.println("[" + i + "] " + threadName );
                Thread.sleep(200);
            }
        } catch (InterruptedException e) {
            System.out.println("Thread " + threadName + "interrupted.");
            e.printStackTrace();
        }

        System.out.println("Thread " + threadName + " exiting.");
    }

    public void start(){
        System.out.println("Starting " + threadName);
        if(thread == null){
            thread = new Thread(this, threadName);
            thread.start();
        }
    }
}
