export class InventoryItem {
    id!: number;
    name!: string;
    user!: string;
    description!: string;
    location!: string;
    inventoryNumber!: number;
    createdAt!: Date;
    modifiedAt!: Date;
    deleted!: boolean;

    constructor(item?: Partial<InventoryItem>) {
        if (item) {
            Object.assign(this, item);
        }
    }
}
