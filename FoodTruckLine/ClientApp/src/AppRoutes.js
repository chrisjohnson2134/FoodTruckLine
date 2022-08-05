import { Home } from "./components/Home";
import { Line } from "./components/PrimaryLineView";

const AppRoutes = [
    {
    index: true,
    element: <Line />
    },
    {
    path: '/PrimaryLineView',
    element: <Line />
    }
];

export default AppRoutes;
