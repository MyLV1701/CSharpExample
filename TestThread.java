public class TestThread {
    

    public static void main(String[] args) {

        System.out.println("hello world");

        TestThread test = new TestThread();
        test.test();

    }


    private void test() {
        for (;;) {
            
            int par = (int)(Math.random() * 100);
            ReturnValueThread rvt = new ReturnValueThread(par);
            Thread t = new Thread(rvt);
            t.start();

            System.out.println("Generated value ---------->> : " + par);
            // System.out.println("Executed result ---------->> : " + rvt.getValue());

            try {
                Thread.sleep(3000);

            } catch (Exception e) {
                e.printStackTrace();
            }

        }
    }


    public class ReturnValueThread implements Runnable {
        private volatile boolean val;
        private int value;

        public ReturnValueThread(int value) {
            this.value = value;
            val = false;
        }

        public boolean validateMethod() {
            return val;
        }


        @Override
        public void run() {

            if (value % 2 < 1) {
                val = true;

            }
            System.out.println(" INPUT VALUE        : " + value);
            System.out.println(" Validate result    : " + val);

        }

        public boolean getValue() {
            return val;
        }

    }
}
